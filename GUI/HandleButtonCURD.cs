using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUI
{
    public class HandleButtonCURD 
    {

        public void _Handle_button_Them(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnThem);
            _Enable_Button(btnLuu);
            _Enable_Button(btnXoa, false);
            _Enable_Button(btnSua, false);
        }
        public void _Handle_button_GridControl(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnThem);
            _Enable_Button(btnSua);
            _Enable_Button(btnXoa);
            _Enable_Button(btnLuu, false);
        }
        public void _Handle_button_Sua(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnLuu);
            _Enable_Button(btnThem, false);
            _Enable_Button(btnXoa, false);
            _Enable_Button(btnSua, false);
        }
        public void _Handle_button_Naplai(SimpleButton btnThem, SimpleButton btnSua, SimpleButton btnLuu, SimpleButton btnXoa)
        {
            _Enable_Button(btnLuu, false);
            _Enable_Button(btnThem);
            _Enable_Button(btnXoa, false);
            _Enable_Button(btnSua, false);
        }
        public void _Enable_Button(SimpleButton btn, bool trangthai = true)
        {
            if (!btn.Enabled == trangthai) btn.Enabled = trangthai;
        }

        // hash
        String hash = "f0xle@rn025ha$sh";

        public String Encryptor(String pass)
        {
            if (String.IsNullOrEmpty(pass)) return pass;
            byte[] data = UTF8Encoding.UTF8.GetBytes(pass);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triple.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }

        public String Decryptor(String encry)
        {
            if (String.IsNullOrEmpty(encry)) return encry;

            byte[] data1 = Convert.FromBase64String(encry);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triple.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data1, 0, data1.Length);
                    return UTF8Encoding.UTF8.GetString(result);
                }
            }
        }

        public void _Validating(ErrorProvider err, TextEdit txt, CancelEventArgs e, String errorMsg)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txt.Focus();
                err.SetError(txt, errorMsg);
            }
            else
            {
                e.Cancel = false;
                err.SetError(txt, null);
            }
        }
        public void _Validated(ErrorProvider err, TextEdit txt)
        {
            err.SetError(txt, "");
        }
    }
}
