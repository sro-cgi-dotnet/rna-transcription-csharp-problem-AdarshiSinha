using System;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        private const string V = "C";
        private const char V1 = 'G';
        private const char V2 = 'A';
        private const char V3 = 'U';

        public static string ToRna(string nucleotide)
        {
            
            StringBuilder str=new StringBuilder(nucleotide.Length);
            //replacing dna with rna by replacing each element with rna element
            foreach(char i in nucleotide)
            {
                if(i=='G')
                str.Append("C");
                else if(i=='C')
                str.Append("G");
                else if(i=='T')
                str.Append("A");
                else if(i=='A')
                str.Append("U");
                else
                throw new ArgumentException("String should not contain");
            }
           // str+="\0";
           string st= str.ToString();
            return st;
          // throw new NotImplementedException("You need to implement this function.");
        }
    }
}
