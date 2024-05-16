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
            // Xóa các control hi?n có trong panel 2 tr??c khi thêm các button m?i
            pnpanel2.Controls.Clear();

            // Xác ??nh v? trí x ban ??u c?a button
            int startX = 0;

            // Thêm các button vào panel 2 và xác ??nh v? trí cho m?i button
            foreach (ButtonWithImage btn in buttons)
            {
                // ??t kích th??c cho button
                btn.Size = new System.Drawing.Size(200, 100);

                // T?o hình ?nh m?i v?i kích th??c b?ng m?t n?a c?a kích th??c button
                Image resizedImage = new Bitmap(btn.Width / 2, btn.Height / 2);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(btn.ImageSource, new Rectangle(0, 0, resizedImage.Width, resizedImage.Height));
                }

                // ??t v? trí cho hình ?nh
                int imageY = 10; // Kho?ng cách t? mép trên c?a button
                int imageHeight = btn.Height / 2;
                btn.Image = resizedImage;

                // ??t v? trí cho v?n b?n
                int textY = imageY + imageHeight + 20;
                int textHeight = btn.Height - imageHeight - 20;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.ImageAlign = ContentAlignment.TopCenter;

                // ??t v?n b?n cho button
                btn.Text = btn.Text;
                btn.Font = new Font(btn.Font.FontFamily, 10); // Thi?t l?p kích c? phù h?p cho v?n b?n

                // ??t v? trí cho button
                btn.Location = new Point(startX, 1); // ??t v? trí theo hàng ngang, v?i kho?ng cách là 1 pixel
                startX += btn.Width + 1; // C?ng thêm chi?u r?ng c?a button và kho?ng cách gi?a các button

                // Thêm button vào panel 2
                pnpanel2.Controls.Add(btn);
            }
        }

        private void btquanly_Click(object sender, EventArgs e)
        {
            // Kh?i t?o các button cho ch?c n?ng Qu?n lý
            ButtonWithImage[] quanLyButtons = new ButtonWithImage[]
            {
                new ButtonWithImage() { Text = "Nhân viên", ImageSource = Properties.Resources.pngegg__1_ },
                new ButtonWithImage() { Text = "Nhà cung c?p", ImageSource = Properties.Resources.kisspng_computer_icons_female_avatar_user_woman_5adcb4d2a12855_0755446815244136506601 },
                new ButtonWithImage() { Text = "Lo?i d??c ph?m", ImageSource = Properties.Resources.images },
                new ButtonWithImage() { Text = "Thu?c", ImageSource = Properties.Resources.transparent_medical_asserts_icon_pill_icon_5dce19bdddab67_172135551573788093908 },
                new ButtonWithImage() { Text = "Nh?p thu?c", ImageSource = Properties.Resources.png_clipart_customs_broking_transport_import_business_export_business_text_orange },
                new ButtonWithImage() { Text = "Th?ng kê nh?p hàng", ImageSource = Properties.Resources.nhap },
                new ButtonWithImage() { Text = "Th?ng kê bán hàng", ImageSource = Properties.Resources.ban },
                new ButtonWithImage() { Text = "Th?ng kê t?n kho", ImageSource = Properties.Resources.kho }
            };

            // Thêm các button vào panel 2
            AddButtonsToPanel2(quanLyButtons);
        }

        private void btbanhang_Click(object sender, EventArgs e)
        {
            // Kh?i t?o các button cho ch?c n?ng Bán hàng
            ButtonWithImage[] banHangButtons = new ButtonWithImage[]
            {
                new ButtonWithImage() { Text = "Bán thu?c", ImageSource = Properties.Resources.pngegg__1_ },
                new ButtonWithImage() { Text = "Thông tin thu?c", ImageSource = Properties.Resources.kisspng_computer_icons_female_avatar_user_woman_5adcb4d2a12855_0755446815244136506601 },
                new ButtonWithImage() { Text = "Tài kho?n", ImageSource = Properties.Resources.images },
                new ButtonWithImage() { Text = "??ng xu?t", ImageSource = Properties.Resources.transparent_medical_asserts_icon_pill_icon_5dce19bdddab67_172135551573788093908 }
            };

            // Thêm các button vào panel 2
            AddButtonsToPanel2(banHangButtons);
        }

        private void btlienhe_Click(object sender, EventArgs e)
        {
            // Kh?i t?o các button cho ch?c n?ng Liên h?
            ButtonWithImage[] lienHeButtons = new ButtonWithImage[]
            {
                // Add buttons as needed
            };

            // Thêm các button vào panel 2
            AddButtonsToPanel2(lienHeButtons);
        }
    }
}
