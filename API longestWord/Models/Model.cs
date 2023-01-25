using Microsoft.VisualStudio.Services.FormInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace API_longestWord.Models
{
        public class Model
        {
        CLongest cLongest=new CLongest();
            public string longestLength(string Inputvalue)
            {
            string OutputValue = string.Empty;
            Inputvalue = Regex.Replace(Inputvalue, @"\d", string.Empty);
            if (Inputvalue.Any(char.IsUpper))
            {
                string[] split = Regex.Split(Inputvalue, @"([A-Z][a-z]*)");
                foreach (string s1 in split)
                {
                    if (s1 != "")
                        if ((s1[0] >= 'A' && s1[0] <= 'Z'))
                        {
                            if (s1.Length > OutputValue.Length)
                            {
                                OutputValue = s1;
                            }
                        }
                }
            }
            else
            {
                return "no any string having capital latter!!";
            }
            return OutputValue;
    
        }
        }
    }
