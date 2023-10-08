/*
 * File name: Question.cs
 * Author: Dhanashri, Ivan, Agnita 
 * Creation Date: 03 April, 2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QuizGameLibrary
{
    [DataContract]
    public class Question
    {
        [DataMember]
        private string _questionText;
        [DataMember]
        private string _answer;
        private Boolean optionsShuffled = false;
        [DataMember]
        //question variables 
        public string QuestionText
        {
            get { return _questionText; }
            private set { _questionText = value; }
        }
        [DataMember]
        //answer variables
        public string Answer
        {
            get { return _answer; }
            private set { _answer = value; }
        }

        //Question question = new();
        // question.Answer will get the answer
        // question.QuestionText will get the question
        [DataMember]
        private List<string> Options;

        //default constractor
        public Question()
        {
        }

        // constructor with 3 arguments
        internal Question(string questionText, string answer, List<string> options)
        {
            this._questionText = questionText;
            this._answer = answer;
            this.Options = options;
            //ShuffleOptions();
        }

        /*private void ShuffleOptions()
        {
            Options.Add(this.Answer);
            Random random = new Random();
            Options = Options.OrderBy(option => random.Next()).ToList();
        }*/

        // getting randam options
        public List<string> GetOptions()
        {
            List<string> options = new List<string>();

            options.Add(this.Answer);
            foreach (string item in this.Options)
            {
                options.Add(item);
            }

            Random random = new Random();
            options = options.OrderBy(option => random.Next()).ToList();
            optionsShuffled = true;

            return options;
        }

        // string to display
        public override string ToString()
        {
            string result = "";
            List<string> options = GetOptions();
            result += $"{_questionText}\n";

            char questionNumber = 'a';
            result += "\nChoose an option from the list below:\n";
            foreach (string item in options)
            {
                //make this random
                result += $"{questionNumber++}. {item}\n";
            }

            result += "\n";

            return result;
        }

    }
}