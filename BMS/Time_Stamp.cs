using ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace BMS
{
    public partial class Time_Stamp : Form
    {
        //Bytes
        private int refsize;
        private byte[] refbuf;
        private int matsize;
        private byte[] matbuf;

        //Strings
        private byte[] refstr;
        private byte[] matstr;
        ModelView.AMStamp _amstamp = new ModelView.AMStamp();
        public Time_Stamp()
        {
            InitializeComponent();
            refsize = 0;
            refbuf = new byte[512];
            matsize = 0;
            matbuf = new byte[256];


            refstr = new Byte[768];
            matstr = new Byte[384];

        }

        private void ValidateLoop_Tick(object sender, EventArgs e)
        {
            int wm = fpengine.GetWorkMsg();
            int rm = fpengine.GetRetMsg();
            if(wm == -1)
                fpengine.CaptureTemplate();
            switch (wm)
            {
                case fpengine.FPM_DEVICE:
                    label1.Text = "Not Open Device";
                    break;
                case fpengine.FPM_PLACE:
                    label1.Text = "Place Finger ...";
                    break;
                case fpengine.FPM_LIFT:
                    label1.Text = "Lift Finger ...";
                    break;
                case fpengine.FPM_CAPTURE:
                    break;
                //case fpengine.FPM_ENROLL:
                //    {
                //        if (rm == 1)
                //        {
                //            label1.Text = "Enrol OK";
                //            if (true) //checkBox1.Checked
                //            {
                //                fpengine.GetBase64StrByEnl(0, refstr);
                //                string un = System.Text.Encoding.Default.GetString(refstr);
                //                //textBox1.Text = un;
                //            }
                //            else
                //            {
                //                fpengine.GetTemplateByEnl(refbuf, ref refsize);
                //            }
                //        }
                //        else
                //        {
                //            label1.Text = "Enrol Fail";
                //        }
                //        TimeStamp.Enabled = false;
                //    }
                //    break;
                case fpengine.FPM_GENCHAR:
                    {
                        if (rm == 1)
                        {
                            label1.Text = "Capture OK";
                            if (true) //checkBox1.Checked
                            {
                                fpengine.GetBase64StrByCap(0, matstr);
                                fpengine.GetTemplateByCap(matbuf, ref matsize);
                                string un = System.Text.Encoding.Default.GetString(matstr);
                                _amstamp.Stamp = matbuf;
                                _amstamp.StampString = un;

                                string url = "https://localhost:7021/api/Values/GetTimeStamp";
                                string strResponse = HttpRequest.CreateRequest(url, _amstamp);
                                _amstamp = JsonConvert.DeserializeObject<AMStamp>(strResponse);

                            }
                            //else
                            //{
                            //    fpengine.GetTemplateByCap(matbuf, ref matsize);
                            //}
                            //if (1 > 0 || refsize > 0) //textBox1.TextLength > 0 || refsize > 0
                            //{
                            //    int scope = 0;
                            //    if (true) //checkBox1.Checked
                            //    {
                            //        if (1 > 0) //textBox1.TextLength
                            //        {
                            //            refstr = System.Text.Encoding.Default.GetBytes(""); //textBox1.Text
                            //            matstr = System.Text.Encoding.Default.GetBytes(""); //textBox2.Text
                            //            scope = fpengine.MatchBase64Str(matstr, refstr, 0);
                            //        }
                            //    }
                            //    else
                            //    {
                            //        if (refsize > 0)
                            //        {
                            //            scope = fpengine.MatchTemplateOne(matbuf, refbuf, 512);
                            //        }
                            //    }
                            //    if (scope >= 80)
                            //    {
                            //        label1.Text = "Match OK::" + scope.ToString();
                            //    }
                            //    else
                            //    {
                            //        label1.Text = "Match Fail:" + scope.ToString();
                            //    }
                            //}
                        }
                        else
                        {
                            label1.Text = "Capture Fail";
                        }
                        //ValidateLoop.Enabled = false;
                        fpengine.CaptureTemplate();

                    }
                    break;
                case fpengine.FPM_NEWIMAGE:
                    {
                        System.Drawing.Bitmap bmp = new Bitmap(255, 288);
                        Graphics g = Graphics.FromImage(bmp);
                        fpengine.DrawImage(g.GetHdc(), 0, 0);
                        g.Dispose();
                        TimeStamp.Image = bmp;
                    }
                    break;
            }
            
        }

        private void Time_Stamp_Load(object sender, EventArgs e)
        {
            //TimeStamp.ImageLocation = ModelView.CommonFunctions.GetProjectPath();
            fpengine.CloseDevice();
            if (fpengine.OpenDevice(0, 0, 0) == 1)
            {
                if (fpengine.LinkDevice(1) == 1)
                {
                    label1.Text = "Open Device OK!";
                    fpengine.CaptureTemplate();
                    ValidateLoop.Enabled = true;
                }
                else
                {
                    label1.Text = "Link Device Fail";
                }
            }
            else
            {
                label1.Text = "Open Device Fail";
            }

        }
    }
}
