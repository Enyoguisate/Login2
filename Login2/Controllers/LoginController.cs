using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login2.Controllers
{
    public class LoginController : Controller
    {
        private static string LETTERS = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        private static string NUMBERS = "0,1,2,3,4,5,6,7,8,9";

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginAccess(Login2.Models.Login thisLogin)
        {
            string[] myLettersArray = LETTERS.Split(',');
            string[] myNumbersArray = NUMBERS.Split(',');

            if (!ModelState.IsValid)
            {
                return View("ErrorLogin");
            }
            var errorpass = thisLogin.Password.ToList();
            
            for (int i = 0; i < 2; i++)
            {
                foreach(string item in myNumbersArray)
                {
                    if (errorpass[i].ToString().ToUpper() == item)
                    {
                        return View("ErrorLogin");
                    }
                }                
            }

            int count = 0;
            bool isNumberOrLetter = false;

            foreach (char item in errorpass)
            {
                foreach(string itemNumber in myNumbersArray)
                {
                    if (item == itemNumber.FirstOrDefault())
                    {
                        isNumberOrLetter = true;
                    }
                }
                foreach (string itemLetter in myLettersArray)
                {
                    if (item.ToString().ToUpper() == itemLetter)
                    {
                        isNumberOrLetter = true;
                    }
                }
                if (!isNumberOrLetter)
                {
                    count++;
                }
                isNumberOrLetter = false;
            }
            if (count != 2)
            {
                return View("ErrorLogin");
            }
            
            int acu = 0;
            for(int i=errorpass.Count()-3;i<errorpass.Count(); i++)
            {
                try
                {
                    if (int.Parse(errorpass[i].ToString()) < 3 || int.Parse(errorpass[i].ToString()) > 8)
                    {
                        return View("ErrorLogin");
                    }
                    acu += int.Parse(errorpass[i].ToString());

                }
                catch(Exception a)
                {
                    return View("ErrorLogin");
                }
            }
            
            return acu<15 ? View("CorrectLogin") : View("ErrorLogin");
        }
        /*
         * La contraseña debe tener 3 letras al inicio, 2 caracteres especiales y terminar con 3 numeros
         * entre 3 y 8 que sumados den menos de 15
         */



        public ActionResult LoginAccessComoDeberiaQuedar(Login2.Models.Login thisLogin)
        {
           

            if (!ModelState.IsValid)
            {
                return View("ErrorLogin");
            }


            return View("CorrectLogin");
        }
    }
}