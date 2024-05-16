using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BANTHUOC;

namespace BANTHUOC
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void AddButtonsToPanel2(ButtonWithImage[] buttons)
        {
            // X�a c�c control hi?n c� trong panel 2 tr??c khi th�m c�c button m?i
            pnpanel2.Controls.Clear();

            // X�c ??nh v? tr� x ban ??u c?a button
            int startX = 0;

            // Th�m c�c button v�o panel 2 v� x�c ??nh v? tr� cho m?i button
            foreach (ButtonWithImage btn in buttons)
            {
                // ??t k�ch th??c cho button
                btn.Size = new System.Drawing.Size(200, 100);

                // T?o h�nh ?nh m?i v?i k�ch th??c b?ng m?t n?a c?a k�ch th??c button
                Image resizedImage = new Bitmap(btn.Width / 2, btn.Height / 2);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(btn.ImageSource, new Rectangle(0, 0, resizedImage.Width, resizedImage.Height));
                }

                // ??t v? tr� cho h�nh ?nh
                int imageY = 10; // Kho?ng c�ch t? m�p tr�n c?a button
                int imageHeight = btn.Height / 2;
                btn.Image = resizedImage;

                // ??t v? tr� cho v?n b?n
                int textY = imageY + imageHeight + 20;
                int textHeight = btn.Height - imageHeight - 20;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.ImageAlign = ContentAlignment.TopCenter;

                // ??t v?n b?n cho button
                btn.Text = btn.Text;
                btn.Font = new Font(btn.Font.FontFamily, 10); // Thi?t l?p k�ch c? ph� h?p cho v?n b?n

                // ??t v? tr� cho button
                btn.Location = new Point(startX, 1); // ??t v? tr� theo h�ng ngang, v?i kho?ng c�ch l� 1 pixel
                startX += btn.Width + 1; // C?ng th�m chi?u r?ng c?a button v� kho?ng c�ch gi?a c�c button

                // Th�m button v�o panel 2
                pnpanel2.Controls.Add(btn);
            }
        }

        private void btquanly_Click(object sender, EventArgs e)
        {
            // Kh?i t?o c�c button cho ch?c n?ng Qu?n l�
            ButtonWithImage[] quanLyButtons = new ButtonWithImage[]
            {
                new ButtonWithImage() { Text = "Nh�n vi�n", ImageSource = Properties.Resources.pngegg__1_ },
                new ButtonWithImage() { Text = "Nh� cung c?p", ImageSource = Properties.Resources.kisspng_computer_icons_female_avatar_user_woman_5adcb4d2a12855_0755446815244136506601 },
                new ButtonWithImage() { Text = "Lo?i d??c ph?m", ImageSource = Properties.Resources.images },
                new ButtonWithImage() { Text = "Thu?c", ImageSource = Properties.Resources.transparent_medical_asserts_icon_pill_icon_5dce19bdddab67_172135551573788093908 },
                new ButtonWithImage() { Text = "Nh?p thu?c", ImageSource = Properties.Resources.png_clipart_customs_broking_transport_import_business_export_business_text_orange },
                new ButtonWithImage() { Text = "Th?ng k� nh?p h�ng", ImageSource = Properties.Resources.nhap },
                new ButtonWithImage() { Text = "Th?ng k� b�n h�ng", ImageSource = Properties.Resources.ban },
                new ButtonWithImage() { Text = "Th?ng k� t?n kho", ImageSource = Properties.Resources.kho }
            };

            // Th�m c�c button v�o panel 2
            AddButtonsToPanel2(quanLyButtons);
        }

        private void btbanhang_Click(object sender, EventArgs e)
        {
            // Kh?i t?o c�c button cho ch?c n?ng B�n h�ng
            ButtonWithImage[] banHangButtons = new ButtonWithImage[]
            {
                new ButtonWithImage() { Text = "B�n thu?c", ImageSource = Properties.Resources.pngegg__1_ },
                new ButtonWithImage() { Text = "Th�ng tin thu?c", ImageSource = Properties.Resources.kisspng_computer_icons_female_avatar_user_woman_5adcb4d2a12855_0755446815244136506601 },
                new ButtonWithImage() { Text = "T�i kho?n", ImageSource = Properties.Resources.images },
                new ButtonWithImage() { Text = "??ng xu?t", ImageSource = Properties.Resources.transparent_medical_asserts_icon_pill_icon_5dce19bdddab67_172135551573788093908 }
            };

            // Th�m c�c button v�o panel 2
            AddButtonsToPanel2(banHangButtons);
        }

        private void btlienhe_Click(object sender, EventArgs e)
        {
            // Kh?i t?o c�c button cho ch?c n?ng Li�n h?
            ButtonWithImage[] lienHeButtons = new ButtonWithImage[]
            {
                // Add buttons as needed
            };

            // Th�m c�c button v�o panel 2
            AddButtonsToPanel2(lienHeButtons);
        }
    }
}
