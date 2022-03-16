using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba2.FactoryMetod;

namespace Laba2
{
    public partial class MainForm : Form
    {
        static OnePoint _onePoint = new OnePoint();
        static TwoPoint _twoPoint = new TwoPoint();

        static int _maxTimeCooking = 0;
        public MainForm()
        {
            InitializeComponent();
            UpdateInfo();

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        void UpdateInfo()
        {
            //Обновить информацию о сотрудниках первой точки
            _onePoint.OneKitchen.CountEmployees =   int.Parse(tb_Res1Kitchen1.Text);
            _onePoint.TwoKitchen.CountEmployees =   int.Parse(tb_Res1Kitchen2.Text);
            _onePoint.ThreeKitchen.CountEmployees = int.Parse(tb_Res1Kitchen3.Text);
            _onePoint.FourKitchen.CountEmployees =  int.Parse(tb_Res1Kitchen4.Text);

            //Обновить информацию о сотрудниках второй точки
            _twoPoint.OneKitchen.CountEmployees =   int.Parse(tb_Res2Kitchen1.Text);
            _twoPoint.TwoKitchen.CountEmployees =   int.Parse(tb_Res2Kitchen2.Text);
            _twoPoint.ThreeKitchen.CountEmployees = int.Parse(tb_Res2Kitchen3.Text);
            _twoPoint.FourKitchen.CountEmployees =  int.Parse(tb_Res2Kitchen4.Text);

            _maxTimeCooking = int.Parse(tb_maxTimeCooking.Text);

            //Обновление готовки
            _onePoint.UpdateCooking();
            _twoPoint.UpdateCooking();

            //Получение списка всех продуктов, которые готовятся
            rtb_Res1.Text = _onePoint.GetAllProducts();
            rtb_Res2.Text = _twoPoint.GetAllProducts();

            //Обновить информацию о загруженности
            UpdateInfoWorkloadRes1();
            UpdateInfoWorkloadRes2();

            label_Incost.Text = "Доход: " + Income.Value + " руб.";
        }

        private void ClientLeftBtn_Click(object sender, EventArgs e)
        {
            NewClient(_onePoint);
        }

        private void ClientRightBtn_Click(object sender, EventArgs e)
        {
            NewClient(_twoPoint);
        }

        private void NewClient(Point point)
        {
            Client client = new Client();
            List<IProduct> products = client.MakeAnOrder();

            for (int i = 0; i < products.Count; i++)
            {
                point.AddProduct(products[i]);
            }
        }

        /// <summary>
        /// Обновление информации загруженности первой точки
        /// </summary>
        private void UpdateInfoWorkloadRes1()
        {
            label_WorkloadRes1Kitchen1.Text 
                = _onePoint.OneKitchen.GetWorkload(_maxTimeCooking) + "%";
            label_WorkloadRes1Kitchen2.Text 
                = _onePoint.TwoKitchen.GetWorkload(_maxTimeCooking) + "%";
            label_WorkloadRes1Kitchen3.Text 
                = _onePoint.ThreeKitchen.GetWorkload(_maxTimeCooking) + "%";
            label_WorkloadRes1Kitchen4.Text 
                = _onePoint.FourKitchen.GetWorkload(_maxTimeCooking) + "%";
        }

        /// <summary>
        /// Обновление информации загруженности второй точки
        /// </summary>
        private void UpdateInfoWorkloadRes2()
        {
            label_WorkloadRes2Kitchen1.Text
                = _twoPoint.OneKitchen.GetWorkload(_maxTimeCooking) + "%";
            label_WorkloadRes2Kitchen2.Text
                = _twoPoint.TwoKitchen.GetWorkload(_maxTimeCooking) + "%";
            label_WorkloadRes2Kitchen3.Text
                = _twoPoint.ThreeKitchen.GetWorkload(_maxTimeCooking) + "%";
            label_WorkloadRes2Kitchen4.Text
                = _twoPoint.FourKitchen.GetWorkload(_maxTimeCooking) + "%";
        }


    }
}
