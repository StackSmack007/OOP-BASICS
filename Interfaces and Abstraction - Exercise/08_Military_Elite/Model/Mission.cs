using Military.Contracts;
using System;

namespace Military.Model
{
    public class Mission : IMission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string missionState)
        {
            CodeName = codeName;
            State = missionState;
        }

        public string CodeName
        {
            get
            {
                return codeName;
            }
            private set
            {
                codeName = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("Not valid mission state this mission is skipped!");
                }
                state = value;
            }
        }

        public void CompleteMission()
        {
            State = "Finished";
        }

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}