using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Getränkeautomat
{
    class Automat
    {

        private string[] produkte = { };
        private Double[] preise = { };
        private int[] vorrat = { };

        
        public Automat(){}

        public Automat(String[] namen, Double[] preise, int[] vorrat)
        {
            this.produkte = namen;
            this.preise = preise;
            this.vorrat = vorrat;
        }


        public Boolean checkProdukt(int produkt)
        {
            if (vorrat[produkt] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public Boolean ejectProdukt(int produkt)
        {
            if (vorrat[produkt] != 0)
            {
                vorrat[produkt] -= 1;
                return true;
            }else
            {
                return false;
            }

        }


        public double getPrice(int produkt)
        {
            return preise[produkt];
        }
    }

}
