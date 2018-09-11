using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string str=null;
            foreach(char i in nucleotide)
            {
                if(i=='G')
                str+='C';
                else if(i=='C')
                str+='G';
                else if(i=='T')
                str+='A';
                else if(i=='A')
                str+='U';
                else
                throw new ArgumentException("String should not contain");
            }
           // str+="\0";
            return str;
          // throw new NotImplementedException("You need to implement this function.");
        }
    }
}
