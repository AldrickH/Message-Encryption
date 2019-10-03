using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Message_Encryption
{
    class Encryption
    {
        public class DES
        {

            byte[] key = { }; //Encryption Key
            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };

            public string Encrypt(string strData, string encryptionKey)
            {
                byte[] inputByteArray;

                try
                {
                    // DESCryptoServiceProvider is a cryptography class defind in c#.
                    DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();
                    MemoryStream Objmst = new MemoryStream();

                    key = Encoding.UTF8.GetBytes(encryptionKey);
                    inputByteArray = Encoding.UTF8.GetBytes(strData);

                    CryptoStream Objcs = new CryptoStream(Objmst, ObjDES.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                    Objcs.Write(inputByteArray, 0, inputByteArray.Length);
                    Objcs.FlushFinalBlock();
                    return Convert.ToBase64String(Objmst.ToArray());//encrypted string
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public string Decrypt(string strCrypted, string encryptionKey)
            {
                byte[] inputByteArray = new byte[strCrypted.Length];

                try
                {
                    DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();
                    MemoryStream Objmst = new MemoryStream();

                    key = Encoding.UTF8.GetBytes(encryptionKey);
                    inputByteArray = Convert.FromBase64String(strCrypted);

                    CryptoStream Objcs = new CryptoStream(Objmst, ObjDES.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                    Objcs.Write(inputByteArray, 0, inputByteArray.Length);
                    Objcs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    return encoding.GetString(Objmst.ToArray());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public class AES
        {

            public string Encrypt(string strData, string encryptionKey)
            {
                RijndaelManaged objrij = new RijndaelManaged();

                objrij.Mode = CipherMode.CBC; //set the mode for operation of the algorithm  
                objrij.Padding = PaddingMode.PKCS7; //set the padding mode used in the algorithm.
                objrij.KeySize = 0x80; //set the size, in bits, for the secret key.
                objrij.BlockSize = 0x80; //set the block size in bits for the cryptographic operation.

                byte[] passBytes = Encoding.UTF8.GetBytes(encryptionKey); //set the symmetric key that is used for encryption & decryption.
                byte[] textDataByte = Encoding.UTF8.GetBytes(strData);
                byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //set the initialization vector (IV) for the symmetric algorithm
                int len = passBytes.Length;


                if (len > EncryptionkeyBytes.Length) len = EncryptionkeyBytes.Length;

                Array.Copy(passBytes, EncryptionkeyBytes, len);

                ICryptoTransform objtransform = objrij.CreateEncryptor(EncryptionkeyBytes, EncryptionkeyBytes); //Creates symmetric AES object with the current key and initialization vector IV.

                return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length)); //Final transform the test string.
            }

            public string Decrypt(string encryptedText, string encryptionKey)
            {
                RijndaelManaged objrij = new RijndaelManaged();

                objrij.Mode = CipherMode.CBC;
                objrij.Padding = PaddingMode.PKCS7;
                objrij.KeySize = 0x80;
                objrij.BlockSize = 0x80;

                byte[] encryptedTextByte = Convert.FromBase64String(encryptedText);
                byte[] passBytes = Encoding.UTF8.GetBytes(encryptionKey);
                byte[] EncryptionkeyBytes = new byte[0x10];

                int len = passBytes.Length;

                if (len > EncryptionkeyBytes.Length) len = EncryptionkeyBytes.Length;

                Array.Copy(passBytes, EncryptionkeyBytes, len);
                objrij.Key = EncryptionkeyBytes;
                objrij.IV = EncryptionkeyBytes;

                byte[] TextByte = objrij.CreateDecryptor(EncryptionkeyBytes, EncryptionkeyBytes).TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);

                return Encoding.UTF8.GetString(TextByte);  //it will return readable string
            }
        }
    }
}
