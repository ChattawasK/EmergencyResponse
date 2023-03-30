using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergencyResponseModels
{
    public class ExcemClass
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string QuestionTH { get; set; }
        public string QuestionEN { get; set; }
        public List<ChoiceClass> Choices { get; set; }
        public string Answer { get; set; }
        public string IsCorrect { get; set; }
        public string UserChoose { get; set; }
    }
    public class ChoiceClass
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }

    }

    public class RequestAnswerClass
    {
        public string Id { get; set; }
        public string WatchYoutube { get; set; }
        public string AsOfDate { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Companay { get; set; }
        public List<AnswerClass> Answers { get; set; }

    }
    public class AnswerClass
    {

        public string No { get; set; }
        public string Answer { get; set; }
    }

    public class ResponseAnswerClass
    {
        public string Id { get; set; }
        public string WatchYoutube { get; set; }
        public string AsOfDate { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Companay { get; set; }
        public IList<ExcemClass> Excems { get; set; }
    }




    public class ExcemDetail
    {
        public IList<ExcemClass> GetExcemDetail()
        {
            List<ExcemClass> excems = new List<ExcemClass>()
            {
                 new ExcemClass(){
                    No = "1",
                    Name = "ExcemOne",
                    QuestionTH = "พื้นที่สูบบุหรี่ภายในบริษัท ฟรีสแลนด์ คัมพิน่า(โรงงานสำโรง) มี4 จุด : หน้าโรงงานติดฝั่งโอวัลติน บริเวณต้นลั่นทม ใกล้ห้องน้ำสำนักงาน Facility ,บริเวณใกล้ที่จอดรถจักรยานยนต์ ",
                    QuestionEN = "smoking area in FCT have 4 Point: Infront of the factory, beside Ovaltine factory, around Frangipani tree, near the restroom, beside facility office, near motorcycle parking lot.",
                    Answer ="True"
                 },
                 new ExcemClass() {
                    No = "2",
                    Name = "ExcemTwo",
                    QuestionTH = "การสัญจรในพื้นที่โรงงานต้องเดินตาม  Walkways และข้ามถนนในทางม้าลายเท่านั้น",
                    QuestionEN = "Strictly walk inside Walkway and cross at crosswalk.",
                    Answer ="True"},

                 new ExcemClass() {
                    No = "3",
                    Name = "ExcemTree",
                    QuestionTH = "เมื่อเกิดอุบัติเหตุในพื้นที่ทำงานต้องแจ้งหัวหน้างาน หรือผู้ควบคุมงาน หรือเจ้าหน้าที่ความปลอดภัยในการทำงาน (จป.)ให้รับทราบทุกครั้ง",
                    QuestionEN = "When you are happening incident must be informed Your leader or Safety officer.",
                    Answer ="True"},
                 new ExcemClass() {
                    No = "4",
                    Name = "ExcemFour",
                    QuestionTH = "ยาหนะภายในบริษัท ฟรีสแลนด์ คัมพิน่า (โรงงานสำโรง) ที่วิ่งบริเวณรอบนอก จำกัดความเร็วที่ 15 กม/ชม.",
                    QuestionEN = "Speed limit of vehicle outside manufacturing are in FCT Samrong plant: 15 km/hour.",
                    Answer ="False"},
                 new ExcemClass() {
                    No = "5",
                    Name = "ExcemFive",
                    QuestionTH = "เมื่อท่านเดินขึ้นหรือลงบันได ท่านควรจับราวบันไดทุกครั้ง",
                    QuestionEN = "When you walk on the stairs, you should hold the handrail.",
                    Answer ="True"},
                 new ExcemClass() {
                     No = "6",
                     Name = "ExcemSix",
                     QuestionTH = "ความปลอดภัยบนท้องถนนไม่ได้เป็นส่วนหนึ่งของข้อปฏิบัติด้านความปลอดภัย 7 ข้อ",
                     QuestionEN = "Road safety are not part of 7 life Saving Rules.",
                      Answer ="False"},
                 new ExcemClass() {
                    No = "7",
                    Name = "ExcemSeven",
                    QuestionTH = "หากท่านได้ยินเสียงสัญญานแจ้งเตือนไฟไหม้ ให้ใช้ลิฟต์และไปที่จุดรวมพลและอย่าตื่นตระหนก",
                    QuestionEN = "When you hear the fire alarm, use the elevator, go to the assembly point and do not be panic.",
                    Answer ="False"},
                 new ExcemClass() {
                    No = "8",
                   Name = "ExcemEight",
                   QuestionTH = "ป้าย/สัญญาลักษณ์ห้ามหรือเตือนภัยภายในบริษัท เราไม่จำเป็นต้องปฏิบัติตาม",
                   QuestionEN = "Prohibition signs , warning signs posted in the company , we do not need to follow.",
                    Answer ="False"},
                 new ExcemClass() {
                    No = "9",
                    Name = "ExcemNine",
                    QuestionTH = "ผู้เยี่ยมชมโรงงานไม่จำเป็นต้องมีพนักงานโฟร์โมสต์พาไปเสมอ",
                    QuestionEN = "Visitor are not required to be escorted throughout his/her visit by FCT employee.",
                    Answer ="False"},
                 new ExcemClass() {
                    No = "10",
                    Name = "ExcemTen",
                    QuestionTH = "ผู้เยี่ยมชมโรงงานสามารถใส่แหวนเครื่องประดับนาฬิกาเข้าไปในพื้นที่การผลิตและหยีบจับสัมผัสสินค้าได้",
                    QuestionEN = "Visitor are wearing jewelry (watch,ring,brecelet) when entering the production line and can touch moving component.",
                    Answer ="False"},
        };


            for (var i = 0; i < excems.Count(); i++)
            {
                var item = excems[i];
                ChoiceClass c1 = new ChoiceClass();
                c1.Id = item.Name + "True";
                c1.Text = "1. True / ถูก";
                c1.Value = "True";

                ChoiceClass c2 = new ChoiceClass();
                c2.Id = item.Name + "False";
                c2.Text = "2. False / ผิด";
                c2.Value = "False";
                item.Choices = new List<ChoiceClass>();
                item.Choices.Add(c1);
                item.Choices.Add(c2);
            }


            return excems;
        }

        public ResponseAnswerClass GetResponseAnswer()
        {

  
            RequestAnswerClass data = new RequestAnswerClass();
            IList<ExcemClass> excems = GetExcemDetail();

            data.Id = "AAAAA";
            data.AsOfDate = "03/01/2023";
            data.Answers = new List<AnswerClass>();

            List<AnswerClass> ans = new List<AnswerClass>()
         {
                 new AnswerClass(){
                        No="ExcemOne",
                        Answer="True" },
                 new AnswerClass(){
                        No="ExcemTwo",
                        Answer="True"},
                 new AnswerClass(){
                        No="ExcemTree",
                        Answer="True"},
                 new AnswerClass(){
                        No="ExcemFour",
                        Answer="True" },
                 new AnswerClass(){
                        No="ExcemFive",
                        Answer="True"},
                 new AnswerClass(){
                        No="ExcemSix",
                        Answer="True" },
                 new AnswerClass(){
                        No="ExcemSeven",
                        Answer="True" },
                 new AnswerClass(){
                        No="ExcemEight",
                        Answer="True" },
                 new AnswerClass(){
                        No="ExcemNine",
                        Answer="True" },
                 new AnswerClass(){
                        No="ExcemTen",
                        Answer="False"}
          };
            data.Answers = ans;

            for (var i = 0; i < data.Answers.Count; i++)
            {
                var item = data.Answers[i];
                var match = excems.FirstOrDefault(w => w.Name.Contains(item.No));
                if (match != null)
                {
                    if (match.Answer.Contains(item.Answer))
                    {
                        match.IsCorrect = "1";
                    }
                    else
                    {
                        match.IsCorrect = "0";
                    }
                    match.UserChoose = item.Answer;
                }
                else
                {
                    match.IsCorrect = "0";
                }
                
            }


            ResponseAnswerClass res = new ResponseAnswerClass();
            res.Id = data.Id;
            res.WatchYoutube = data.WatchYoutube;
            res.AsOfDate = data.AsOfDate;
            res.Phone = data.Phone;
            res.FullName = data.FullName;
            res.Companay = data.Companay;
            res.Excems = excems;

            return res;
        }
    }



}

