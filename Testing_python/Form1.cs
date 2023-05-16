using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Testing_python
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init_Lang_to_Choice();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
        }

        void Init_Lang_to_Choice()
        {
            string json = "[{\"Text\":\"Afrikaans (South Africa)\",\"Value\":\"af\"},{\"Text\":\"Albanian (Albania)\",\"Value\":\"sq\"},{\"Text\":\"Amharic (Ethiopia)\",\"Value\":\"am\"},{\"Text\":\"Arabic (Algeria)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Bahrain)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Egypt)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Iraq)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Israel)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Jordan)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Kuwait)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Lebanon)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Mauritania)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Morocco)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Oman)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Qatar)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Saudi Arabia)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (State of Palestine)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Tunisia)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (United Arab Emirates)\",\"Value\":\"ar\"},{\"Text\":\"Arabic (Yemen)\",\"Value\":\"ar\"},{\"Text\":\"Armenian (Armenia)\",\"Value\":\"hy\"},{\"Text\":\"Azerbaijani (Azerbaijan)\",\"Value\":\"az\"},{\"Text\":\"Basque (Spain)\",\"Value\":\"eu\"},{\"Text\":\"Bengali (Bangladesh)\",\"Value\":\"bn\"},{\"Text\":\"Bengali (India)\",\"Value\":\"bn\"},{\"Text\":\"Bosnian (Bosnia and Herzegovina)\",\"Value\":\"bs\"},{\"Text\":\"Bulgarian (Bulgaria)\",\"Value\":\"bg\"},{\"Text\":\"Burmese (Myanmar)\",\"Value\":\"my\"},{\"Text\":\"Catalan (Spain)\",\"Value\":\"ca\"},{\"Text\":\"Chinese, Cantonese (Traditional Hong Kong)\",\"Value\":\"yu\"},{\"Text\":\"Chinese, Mandarin (Simplified, China)\",\"Value\":\"zh\"},{\"Text\":\"Chinese, Mandarin (Traditional, Taiwan)\",\"Value\":\"zh\"},{\"Text\":\"Croatian (Croatia)\",\"Value\":\"hr\"},{\"Text\":\"Czech (Czech Republic)\",\"Value\":\"cs\"},{\"Text\":\"Danish (Denmark)\",\"Value\":\"da\"},{\"Text\":\"Dutch (Belgium)\",\"Value\":\"nl\"},{\"Text\":\"Dutch (Netherlands)\",\"Value\":\"nl\"},{\"Text\":\"English (Australia)\",\"Value\":\"en\"},{\"Text\":\"English (Canada)\",\"Value\":\"en\"},{\"Text\":\"English (Ghana)\",\"Value\":\"en\"},{\"Text\":\"English (Hong Kong)\",\"Value\":\"en\"},{\"Text\":\"English (India)\",\"Value\":\"en\"},{\"Text\":\"English (Ireland)\",\"Value\":\"en\"},{\"Text\":\"English (Kenya)\",\"Value\":\"en\"},{\"Text\":\"English (New Zealand)\",\"Value\":\"en\"},{\"Text\":\"English (Nigeria)\",\"Value\":\"en\"},{\"Text\":\"English (Pakistan)\",\"Value\":\"en\"},{\"Text\":\"English (Philippines)\",\"Value\":\"en\"},{\"Text\":\"English (Singapore)\",\"Value\":\"en\"},{\"Text\":\"English (South Africa)\",\"Value\":\"en\"},{\"Text\":\"English (Tanzania)\",\"Value\":\"en\"},{\"Text\":\"English (United Kingdom)\",\"Value\":\"en\"},{\"Text\":\"English (United States)\",\"Value\":\"en\"},{\"Text\":\"Estonian (Estonia)\",\"Value\":\"et\"},{\"Text\":\"Filipino (Philippines)\",\"Value\":\"fi\"},{\"Text\":\"Finnish (Finland)\",\"Value\":\"fi\"},{\"Text\":\"French (Belgium)\",\"Value\":\"fr\"},{\"Text\":\"French (Canada)\",\"Value\":\"fr\"},{\"Text\":\"French (France)\",\"Value\":\"fr\"},{\"Text\":\"French (Switzerland)\",\"Value\":\"fr\"},{\"Text\":\"Galician (Spain)\",\"Value\":\"gl\"},{\"Text\":\"Georgian (Georgia)\",\"Value\":\"ka\"},{\"Text\":\"German (Austria)\",\"Value\":\"de\"},{\"Text\":\"German (Germany)\",\"Value\":\"de\"},{\"Text\":\"German (Switzerland)\",\"Value\":\"de\"},{\"Text\":\"Greek (Greece)\",\"Value\":\"el\"},{\"Text\":\"Gujarati (India)\",\"Value\":\"gu\"},{\"Text\":\"Hebrew (Israel)\",\"Value\":\"iw\"},{\"Text\":\"Hindi (India)\",\"Value\":\"hi\"},{\"Text\":\"Hungarian (Hungary)\",\"Value\":\"hu\"},{\"Text\":\"Icelandic (Iceland)\",\"Value\":\"is\"},{\"Text\":\"Indonesian (Indonesia)\",\"Value\":\"id\"},{\"Text\":\"Italian (Italy)\",\"Value\":\"it\"},{\"Text\":\"Italian (Switzerland)\",\"Value\":\"it\"},{\"Text\":\"Japanese (Japan)\",\"Value\":\"ja\"},{\"Text\":\"Javanese (Indonesia)\",\"Value\":\"jv\"},{\"Text\":\"Kannada (India)\",\"Value\":\"kn\"},{\"Text\":\"Kazakh (Kazakhstan)\",\"Value\":\"kk\"},{\"Text\":\"Khmer (Cambodia)\",\"Value\":\"km\"},{\"Text\":\"Korean (South Korea)\",\"Value\":\"ko\"},{\"Text\":\"Lao (Laos)\",\"Value\":\"lo\"},{\"Text\":\"Latvian (Latvia)\",\"Value\":\"lv\"},{\"Text\":\"Lithuanian (Lithuania)\",\"Value\":\"lt\"},{\"Text\":\"Macedonian (North Macedonia)\",\"Value\":\"mk\"},{\"Text\":\"Malay (Malaysia)\",\"Value\":\"ms\"},{\"Text\":\"Malayalam (India)\",\"Value\":\"ml\"},{\"Text\":\"Marathi (India)\",\"Value\":\"mr\"},{\"Text\":\"Mongolian (Mongolia)\",\"Value\":\"mn\"},{\"Text\":\"Nepali (Nepal)\",\"Value\":\"ne\"},{\"Text\":\"Norwegian Bokmål (Norway)\",\"Value\":\"no\"},{\"Text\":\"Persian (Iran)\",\"Value\":\"fa\"},{\"Text\":\"Polish (Poland)\",\"Value\":\"pl\"},{\"Text\":\"Portuguese (Brazil)\",\"Value\":\"pt\"},{\"Text\":\"Portuguese (Portugal)\",\"Value\":\"pt\"},{\"Text\":\"Punjabi (Gurmukhi India)\",\"Value\":\"pa\"},{\"Text\":\"Romanian (Romania)\",\"Value\":\"ro\"},{\"Text\":\"Russian (Russia)\",\"Value\":\"ru\"},{\"Text\":\"Kinyarwanda (Rwanda)\",\"Value\":\"rw\"},{\"Text\":\"Serbian (Serbia)\",\"Value\":\"sr\"},{\"Text\":\"Sinhala (Sri Lanka)\",\"Value\":\"si\"},{\"Text\":\"Slovak (Slovakia)\",\"Value\":\"sk\"},{\"Text\":\"Slovenian (Slovenia)\",\"Value\":\"sl\"},{\"Text\":\"Swati (South Africa)\",\"Value\":\"ss\"},{\"Text\":\"Southern Sotho (South Africa)\",\"Value\":\"st\"},{\"Text\":\"Spanish (Argentina)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Bolivia)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Chile)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Colombia)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Costa Rica)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Dominican Republic)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Ecuador)\",\"Value\":\"es\"},{\"Text\":\"Spanish (El Salvador)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Guatemala)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Honduras)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Mexico)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Nicaragua)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Panama)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Paraguay)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Peru)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Puerto Rico)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Spain)\",\"Value\":\"es\"},{\"Text\":\"Spanish (United States)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Uruguay)\",\"Value\":\"es\"},{\"Text\":\"Spanish (Venezuela)\",\"Value\":\"es\"},{\"Text\":\"Sundanese (Indonesia)\",\"Value\":\"su\"},{\"Text\":\"Swahili (Kenya)\",\"Value\":\"sw\"},{\"Text\":\"Swahili (Tanzania)\",\"Value\":\"sw\"},{\"Text\":\"Swedish (Sweden)\",\"Value\":\"sv\"},{\"Text\":\"Tamil (India)\",\"Value\":\"ta\"},{\"Text\":\"Tamil (Malaysia)\",\"Value\":\"ta\"},{\"Text\":\"Tamil (Singapore)\",\"Value\":\"ta\"},{\"Text\":\"Tamil (Sri Lanka)\",\"Value\":\"ta\"},{\"Text\":\"Telugu (India)\",\"Value\":\"te\"},{\"Text\":\"Thai (Thailand)\",\"Value\":\"th\"},{\"Text\":\"Setswana (South Africa)\",\"Value\":\"tn\"},{\"Text\":\"Turkish (Turkey)\",\"Value\":\"tr\"},{\"Text\":\"Tsonga (South Africa)\",\"Value\":\"ts\"},{\"Text\":\"Ukrainian (Ukraine)\",\"Value\":\"uk\"},{\"Text\":\"Urdu (India)\",\"Value\":\"ur\"},{\"Text\":\"Urdu (Pakistan)\",\"Value\":\"ur\"},{\"Text\":\"Uzbek (Uzbekistan)\",\"Value\":\"uz\"},{\"Text\":\"Venda (South Africa)\",\"Value\":\"ve\"},{\"Text\":\"Vietnamese (Vietnam)\",\"Value\":\"vi\"},{\"Text\":\"isiXhosa (South Africa)\",\"Value\":\"xh\"},{\"Text\":\"Zulu (South Africa)\",\"Value\":\"zu\"}]";
            List<ComboboxItem> L = JsonConvert.DeserializeObject<List<ComboboxItem>>(json);
            cboLang.DisplayMember = "Text";
            cboLang.ValueMember = "Value";
            cboLang.DataSource = L;

            //đăng ký hàm xử lý khi cboLang bị thay đổi, cách viết kiểu Labda
            cboLang.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                txtLang.Text = (string)cboLang.SelectedValue;
            };

            cboLang.SelectedValue = "vi";  //mặc định ban đầu chơi tiếng việt
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = Application.StartupPath,
                    FileName = @"C:\Python310\python.exe",  //có thể trên máy bạn sẽ khác path này
                    Arguments = $"test_voice {txtLang.Text}\"{txtSource.Text}\"", //truyền đc lang và text cần nói sang python
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process p = Process.Start(startInfo);
                p.WaitForExit();
                bool get_text = false;
                while (!p.StandardOutput.EndOfStream)
                {
                    string line = p.StandardOutput.ReadLine(); //đọc 1 dòng, lưu vào biến fn
                    if (line.EndsWith(".mp3"))
                        labelStatus.Text = "Playing file: " + line;
                    else
                        labelStatus.Text = line; //đây là các báo lỗi trong python
                    get_text = true;
                    break; //vì code python chỉ ra 1 dòng, nên gặp 1 dòng là té luôn
                }
                if (!get_text) //có khi nào mà python lại ko print ra chữ nào??
                    labelStatus.Text = "Chưa tạo được file mp3";
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Error: " + ex.Message;
            }
        }
    }
}
