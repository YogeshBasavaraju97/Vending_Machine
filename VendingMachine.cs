using System;
namespace VendingMachine
{
    public class VendingMachine
    {

        int cans;
        int tokens;
        string name;
        string location;

        public VendingMachine()
        {
            cans = 0;
            tokens = 0;
        }

        public VendingMachine(int c)
        {
            cans = c;
            tokens = 0;
        }

        public int getCans()
        {
            return cans;

        }

        public int getTokens()
        {
            return tokens;
        }

        public string getName()
        {
            return name;

        }

        public string getLocation()
        {
            return location;
        }

        public void setCans(int c)
        {
            this.cans = c;
        }

        public void setName(string nam)
        {
            this.name = nam;
        }

        public void setLocation(string loc)
        {
            this.location = loc;
        }


        public void addCans(int c)
        {
            cans += c;
        }

        public bool insertToken(int t)
        {
            bool success = false;
            if (cans >= t)
            {
                tokens += t;
                cans -= t;
                success = true;
            }

            return success;

        }

        public bool insertToken()
        {
            return insertToken(1);
        }


        public string ToString()
        {
            return $"Machine:{name} " +
                $" Location: {location}" +
                $"Cans Left: {cans}" +
                $"Tokens: {tokens}";
        }
            
        
    }
}

