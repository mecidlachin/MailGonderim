using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailGonderim
{
    public partial class AnaForm : Form
    {
        private MailMessage mail;
        static AnaForm()
        {
            // SSL/TLS sertifikası doğrulamasını devre dışı bırakma işlemi
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }
        public AnaForm()
        {
            InitializeComponent();
            // Form Başlatıldığında Mail Nesnesi Tanımlanır
            mail = new MailMessage();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string toAddress = txtMail.Text;
            string messageBody = txtMesaj.Text;

            if (string.IsNullOrWhiteSpace(toAddress) || string.IsNullOrWhiteSpace(messageBody))
            {
                MessageBox.Show("Lütfen Mail Adresi Ve Mesajı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                {
                    // Maili gönderen Adres
                    mail.From = new MailAddress("mecidlachin@gmail.com");
                    foreach (var Address in toAddress.Split(','))
                    {
                        mail.To.Add(Address.Trim());
                    }
                    // Mail Konusu
                    mail.Subject = "Konu";
                    //Mail Içeriği
                    mail.Body = messageBody;
                    // Html Formatında
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                    {
                        smtp.Port = 587;
                        smtp.Credentials = new NetworkCredential("mecidlachin@gmail.com", "tcgh plxr fsky qhlu");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                lblGonderimDurumu.Text = "Mail Başarıyla Gönderildi.";
            }
            catch (Exception ex)
            {
                lblGonderimDurumu.Text = "Mail Gönderilirken hata oluştu: " + ex.Message;
            }
            finally
            {
                // Mail Gönderildikten sonra Attachmentleri Temizleme İşlemi
                foreach(var attachment in mail.Attachments)
                {
                    attachment.Dispose();
                }
                mail.Attachments.Clear();
            }
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFİleDialog1 = new OpenFileDialog();

            if (openFİleDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyYolu = openFİleDialog1.FileName;

                // Dosyayı Maile Ekleme İşlemi
                Attachment attachment = new Attachment(dosyYolu);
                mail.Attachments.Add(attachment);

                // Seçilen Dosya Adını Görmek için Labele Dosya İsmini Yazdırma İşlemi

                lblDosyaAdi.Text = $"Seçilen Dosya: {Path.GetFileName(dosyYolu)}";
            }
        }
    }
}
