﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace KW_Guidebook_UI
{
    public partial class KW_Guidebook_Main : Form
    {
        string cnn_Result; //파이썬에 사용자가 선택한 사진을 보낸 후, CNN모델에 적용해 건물의 이름을 파악하여 C#에 건물이름을 전송한 값을 저장한 변수 
        public KW_Guidebook_Main()
        {
            InitializeComponent();      
        }

        //Load Image 버튼을 클릭하면, 사용자의 파일 탐색기에서 사진 선택 후 사진 출력 
        private void button1_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty; //선택한 이미지를 저장하기 위한 변수
            OpenFileDialog dialog = new OpenFileDialog(); //다이얼로그 생성 
            dialog.InitialDirectory = @"C:\"; //다이얼로그 초기 위치 설정

            if (dialog.ShowDialog() == DialogResult.OK) //선택한 이미지 값을 변수에 넣음
            {

                image_file = dialog.FileName; //이미지 경로
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel) //종료
            {
                return;
            }

            image_pictureBox.Image = Bitmap.FromFile(image_file); //Picturebox 컨트롤에 선택한 이미지 넣음
            Image image =Bitmap.FromFile(image_file);
            var image_=GetBytesOfImage(image);
            image_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

         
            // 소켓 생성
            
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999)); // Connect 함수로 로컬(127.0.0.1)의 포트 번호 9999로 대기 중인 socket에 접속

                var data = Encoding.UTF8.GetBytes(image_file); // python 파일에 이미지 경로를 UTF8타입의 byte 배열로 변환
               
                client.Send(BitConverter.GetBytes(data.Length));
                
                client.Send(data); //데이터 전송

                data = new byte[4];  // 데이터의 길이를 수신하기 위한 배열생성
               
                client.Receive(data, data.Length, SocketFlags.None); 

                Array.Reverse(data);

                data = new byte[BitConverter.ToInt32(data, 0)];

                client.Receive(data, data.Length, SocketFlags.None); 

                Console.WriteLine(Encoding.UTF8.GetString(data));  

                cnn_Result=Encoding.UTF8.GetString(data); 
            
            }
          
            
        }
        //이미지 타입 이미지를 바이트타입으로 변환
        public static byte[] GetBytesOfImage(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void image_pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        //이미지에 대한 정보를 출력할 버튼
        private void search_btn_Click(object sender, EventArgs e)
        {
            string CNN_result = "";
            // 소켓 생성
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999)); // Connect 함수로 로컬(127.0.0.1)의 포트 번호 9999로 대기 중인 socket에 접속

                var data = Encoding.UTF8.GetBytes("accept"); 

                client.Send(BitConverter.GetBytes(data.Length)); 

                client.Send(data); 

                data = new byte[4];  

                client.Receive(data, data.Length, SocketFlags.None); 

                Array.Reverse(data);

                data = new byte[BitConverter.ToInt32(data, 0)]; 

                client.Receive(data, data.Length, SocketFlags.None); 

                Console.WriteLine(Encoding.UTF8.GetString(data));  

                CNN_result = Encoding.UTF8.GetString(data); //파이썬에서 돌린 CNN 모델 결과값을 C#에 전송해, cnn_Result에 저장
            }


            //switch문을 사용하여 사진의 건물에 따른 information 창 출력
           
            switch (CNN_result)
            {
                case "bima": //비마관일 경우
                    Bima newForm1 = new Bima();
                    newForm1.Location = new Point(this.Location.X, this.Location.Y); //새로운 창이 기존의 창과 같은 위치로 띄우도록 변경
                    newForm1.Show(); //새로운 창과 기존의 창이 둘다 컨트롤 가능하도록 Show()함수 사용
                    break;
                case "saebit": //새빛관일 경우
                    Saebit newForm2 = new Saebit();
                    newForm2.Location = new Point(this.Location.X, this.Location.Y);
                    newForm2.Show();
                    break;
                case "chambit": //참빛관일 경우
                    Chambit newForm3 = new Chambit();
                    newForm3.Location = new Point(this.Location.X, this.Location.Y);
                    newForm3.Show();
                    break;
                case "hwado": //화도관일 경우
                    Hwado newForm4 = new Hwado();
                    newForm4.Location = new Point(this.Location.X, this.Location.Y);
                    newForm4.Show();
                    break;
                case "oakui": //옥의관일 경우
                    Oakui newForm5 = new Oakui();
                    newForm5.Location = new Point(this.Location.X, this.Location.Y);
                    newForm5.Show();
                    break;
                case "yeongu": //연구관일 경우
                    Yeongu newForm6 = new Yeongu();
                    newForm6.Location = new Point(this.Location.X, this.Location.Y);
                    newForm6.Show();
                    break;
                case "ginyeom": //기념관일 경우
                    Ginyeom newForm7 = new Ginyeom();
                    newForm7.Location = new Point(this.Location.X, this.Location.Y);
                    newForm7.Show();
                    break;
                case "nuri": //누리관일 경우
                    Nuri newForm8 = new Nuri();
                    newForm8.Location = new Point(this.Location.X, this.Location.Y);
                    newForm8.Show();
                    break;
                case "hanoul": //한울관일 경우
                    Hanoul newForm9 = new Hanoul();
                    newForm9.Location = new Point(this.Location.X, this.Location.Y);
                    newForm9.Show();
                    break;
                default:
                    MessageBox.Show("다른 건물 사진을 입력해주세요.");
                    break;
            }

   
        }

        private void KW_Guidebook_Main_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Interval = 1000;//1초
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void road_map_btn_Click(object sender, EventArgs e)
        {
            Map1 newForm1 = new Map1();
            newForm1.Location = new Point(this.Location.X, this.Location.Y);
            newForm1.Show();
        }

        //광운대학교 링크
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kw.ac.kr/ko/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Score score = new Score();
            score.Location = new Point(this.Location.X, this.Location.Y);
            score.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
