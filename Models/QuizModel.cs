using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class QuizModel
    {
        public UserModel Q_user { get; set; }//name
        [Key]
        public int QuizID { get; set; }
        public int Score {get; set;}
        public string Name { get; set; }

        public QuizTools QuizToolInstance { get; set; }// this holds all values in the quiz tools model ie 
                                                       //parasites and seasons .

        
        public List<QuizModel> Seed()
        //be sure to call in startup <3
        {
            //seeded data inside where its own model lives.
            var rec = new List<QuizModel>();

            rec.Add(new QuizModel() {QuizID=1,Name="Lindsey", Score = 10 });
            rec.Add(new QuizModel() {QuizID=2, Name="Aria",Score = 2});
            rec.Add(new QuizModel() {QuizID=3 ,Name="Layla",Score = 77});
            rec.Add(new QuizModel() {QuizID=4,Name="Tony",Score = 99});

            return rec;
        }
        
    }

}
