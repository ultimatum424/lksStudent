using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace lksStudent
{
    public partial class ExamList : ContentPage
    {
        DictExam dictExam = new DictExam();
        public ExamList()
        {
            InitializeComponent();

            PickerSelectSemester.Items.Add("1 семестр");
            PickerSelectSemester.Items.Add("2 семестр");
            PickerSelectSemester.Items.Add("3 семестр");
            PickerSelectSemester.Items.Add("4 семестр");
            PickerSelectSemester.Items.Add("5 семестр");

            AddDictExam();          
        }

        
        private void AddLabelExam(string text, bool isBold)
        {
            if (isBold)
            {
                ExamStack.Children.Add(new Label
                {
                    Text = text,
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 20
                });
            }
            else
            {
                ExamStack.Children.Add(new Label
                {
                    Text = text,
                    TextColor = Color.Black,
                });
            }
        }

        private void AddDictExam()
        {
            dictExam.dict.Add(0, 
                new DictValue("Перспективное программное обеспечение", 
                    "06.06.2016 09:00", 
                    "320 / III", 
                    "Шайхутдинов Ринат Гаптрафикович"));

            dictExam.dict.Add(1,
                new DictValue("Теория автоматов и формальных языков",
                    "09.06.2016 09:00",
                    "320 / III",
                    "Нехорошкова Людмила Георгиевна"));

            dictExam.dict.Add(2,
                new DictValue("Объектно-ориентированное программирование",
                    "14.06.2016 09:00",
                    "318 / III",
                    "Малов Алексей Николаевич"));

            dictExam.dict.Add(3,
                new DictValue("Математическая логика и теория алгоритмов",
                    "20.06.2016 09:00",
                    "318 / III",
                    "Галочкин Владимир Иванович"));

            dictExam.dict.Add(4,
                new DictValue("Учебная практика",
                    "06.07.2016 09:00",
                    "н/у / н/у",
                    "Бородин Андрей Викторович"));
        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ExamStack.Children.Clear();
            
            
            for (int i = 0; i < dictExam.dict.Count; i++)
            {
                AddLabelExam(dictExam.dict[i].Name, true);
                AddLabelExam(dictExam.dict[i].Date, false);
                AddLabelExam(dictExam.dict[i].Сabinet, false);
                AddLabelExam(dictExam.dict[i].Teacher, false);
                AddLabelExam("", false);
            }
        }
        /*
         Pole.RowDefinitions.Add(new RowDefinition());
            Pole.Children.Add(new Label { Text = "Перспективное программное обеспечение", BackgroundColor = Color.Silver}, 0, 1);
            Pole.Children.Add(new Label { Text = "06.06.2016 09:00", BackgroundColor = Color.Silver }, 1, 1);
            Pole.Children.Add(new Label { Text = "320 / III", BackgroundColor = Color.Silver }, 2, 1);
            Pole.Children.Add(new Label { Text = "Шайхутдинов Ринат Гаптрафикович", BackgroundColor = Color.Silver }, 3, 1);
             
         <Grid x:Name="Pole"
          BackgroundColor="Black">
      <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        
      </Grid.RowDefinitions>
      <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="*" />
      </Grid.ColumnDefinitions>
    
      <Label Text="Дисциплина" Grid.Column="0" Grid.Row="0"
             BackgroundColor="Silver"/>
      <Label Text="Дата" Grid.Column="1" Grid.Row="0"
             BackgroundColor="Silver"/>
      <Label Text="Расположение" Grid.Column="2" Grid.Row="0"
             BackgroundColor="Silver"/>
      <Label Text="Преподаватель" Grid.Column="3" Grid.Row="0"
             BackgroundColor="Silver"/>
      
    </Grid>
         */
    }
}
