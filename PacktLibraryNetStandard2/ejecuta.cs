using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PacktLibraryNetStandard2
{
    public class ejecuta
    {
        public (string, int) asd() {


            BankAccount.InterestRate = 0.012M;
            BankAccount jonesAccount = new();
            jonesAccount.AccountName = "Orlando Wong";
            jonesAccount.Balance = 200;

            return ("asd", 1);


        }
        public void fgh() {

            (string, int) asdd = asd();
        
        }


    }
}
