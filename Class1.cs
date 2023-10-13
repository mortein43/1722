using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    
    public class Account
    {
        private static int next_id = 1;
        public int id;
        private int id_currency;
        private int id_account_type;
        private int id_type_of_funds;
        private int id_institution;
        private double amount;
        private string note;
        public Account (int id_currency, int id_account_type, int id_type_of_funds, int id_institution, double amount, string note) 
        {
            id = next_id;
            next_id++;
            this.id_currency = id_currency;
            this.id_account_type = id_account_type;
            this.id_type_of_funds = id_type_of_funds;
            this.id_institution = id_institution;
            this.amount = amount;
            this.note = note;
        }
        public void addAmount (double amount, int new_id)
        {   
            
            if (id == new_id)
            {
                this.amount += amount;
            } else
            {
                return;
            }
        }
        public void takeAwayAmount(double amount, int new_id)
        {
            if (id == new_id)
            {
                this.amount -= amount;
            } else 
            { 
                return; 
            }
        }
        public string screenAccount ()
        {
            return $"id - {id}, id_currency - {id_currency}, id_account_type - {id_account_type}, id_type_of_funds - {id_type_of_funds}, id_institution - {id_institution}, amount - {amount}, note - {note}";
             
        }
    }
}
