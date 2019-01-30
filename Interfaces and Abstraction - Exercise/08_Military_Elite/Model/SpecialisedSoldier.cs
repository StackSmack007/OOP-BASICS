using Military.Contracts;
using System;

namespace Military.Model
{
    public abstract class SpecialisedSoldier : Private,ISpecialisedSoldier 
    {
        private string corpus;

        public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary,string corpus) : base(firstName, lastName, id, salary)
        {
            Corpus = corpus;
        }
        public string Corpus
        {
            get
            {
                return corpus;
            }
            private set
            {
                if (value!="Airforces"&&value!="Marines")
                {
                    throw new ArgumentException("Invalid Corp No input of the whole line!!!");
                }
                corpus = value;
            }
        }
    }
}