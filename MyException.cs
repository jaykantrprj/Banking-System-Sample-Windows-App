using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;




namespace WindowsFormsApplication1
{
    class MyException
    {
        public static int CheckName(string Name)
        {
            int len=0,f=0;
          
            char []a=new char [50] ;
            a=Name.ToCharArray();
            len = a.Length;
            if(len==0)
            {
                f = 1;
                MessageBox.Show("Name is manadatory");
                return f;
            }
            else if (len > 18)
            {
                MessageBox.Show("Your name is too larger");
                f=1;
                return f;
            }
            
            else if (len < 2)
            {
                f=1;
                MessageBox.Show("Your name is too Smaller[Less than two words]");
                return f;
            }

            return f;
        } 
        //Name Done
        public static int CheckAddress(string Address)
        {
            int f = 0, len, attherate = 0;
            char[] a = new char[100];
            
            a = Address.ToCharArray();
            len = a.Length;
            if (len == 0)
            {
                MessageBox.Show("Address is Mandatory");
                f = 1;
                return f;
            }
            return f;
 
        }

        public static int CheckCity(string City)
        {
            int len = 0, f = 0;

            char[] a = new char[50];
            a = City.ToCharArray();
            len = a.Length;
            if (len == 0)
            {
                f = 1;
                MessageBox.Show("City is manadatory");
                return f;
            }
            else if (len > 30)
            {
                MessageBox.Show("Your City name is too larger");
                f = 1;
                return f;
            }

            else if (len < 2)
            {
                f = 1;
                MessageBox.Show("Your city name is too Smaller[Less than two words]");
                return f;
            }

            return f;

        }

        public static int CheckState(string State)
        {

            int len = 0, f = 0;

            char[] a = new char[50];
            a = State.ToCharArray();
            len = a.Length;
            if (len == 0)
            {
                f = 1;
                MessageBox.Show("State is manadatory");
                return f;
            }
            else if (len > 30)
            {
                MessageBox.Show("Your State name is too larger");
                f = 1;
                return f;
            }

            else if (len < 2)
            {
                f = 1;
                MessageBox.Show("Your State name is too Smaller[Less than two words]");
                return f;
            }

            return f;

        }
        public static int CheckEmail(string Email)
        {
            int f = 0, Ndot=0,len,Nattherate=0, i=0,otherchar=0;
            int attherate = '@',Alpha=0, dot = '.' ,sletterstart= 'a' , sletterend='z',cletterstart='A',cletterend='Z',digitstart='0',digitend='9';
            char[] a = new char[100];
            int []num=new int [100];
            a=Email.ToCharArray ();
            len = a.Length;
            if (len < 50)
            {
               
                foreach (char t in a)
                {
                    int temp = Convert.ToInt32(t);
                    num[i] = temp;
                    
                    i++;
                }
                
                foreach (int t in num)
                {
                    if (((t >= sletterstart && t <= sletterend) || (t >= cletterstart && t <= cletterend) || (t >= digitstart && t <= digitend)))
                    {

                        Alpha++;
                        
                    }
                    if (t == attherate)
                    {
                        Nattherate++;
                    }
                    if (t == dot)
                    {
                        Ndot++;
                    }
                }


                if (len == 0)
                {
                    f = 1;
                    MessageBox.Show("Email is madatory");
                    return f;
                }
                else if (Alpha == 0 || Ndot == 0 || Nattherate == 0)
                {
                    MessageBox.Show("Invalid Email");
                    f = 1;
                    return f;
                }
                else if (Ndot != 1)
                {
                    MessageBox.Show("Invalid Email Address[Contains " + Ndot + "  .]");
                    f = 1;
                    return f;
                }
                else if (Nattherate != 1)
                {
                    MessageBox.Show("Invalid Email Address[Contains " + Nattherate + "  @]");
                    f = 1;
                    return f;
                }
                


                else if ((len < 14))
                {
                    f = 1;
                    MessageBox.Show("Invalid Email[To Smaller]");
                    return f;
                }
            }
            return f;
        }


            
        
        public static int CheckContact(string Contact)
        {
            int f = 0, len, other = 0; int i = 0;
            char [] a = new char[100];
            int[] num = new int[100];
            a = Contact.ToCharArray();

            len = a.Length;
            foreach (char t in a)
            {
                int temp = Convert.ToInt32(t);
                num[i] = temp;

                i++;
            }
                
            foreach (int t in num)
            {
                int z = '0', nine = '9';
                if (!(t >= z && t <= nine))
                {
                    f = 1;
                    MessageBox.Show("Invalid contact Number");
                        return f;
                   
                }
            }
            if (len == 0)
            {
                MessageBox.Show("Contact is mandatory");
                f = 1;
                return f;
            }

            

            else if (len !=10)
            {
                f = 1;
                MessageBox.Show("Invalid contact Number");
                return f;
            }
            
            
            return f;

        }
        public static int CkeckPincode(string Pincode)
        {
            int f = 0, len, OtherChar = 0;
            char[] a = new char[100];
           
            a = Pincode.ToCharArray();
            len = a.Length;

            foreach (char t in a)
            {
                int l = Convert.ToInt32(t);
                if (!(l > 0 && l<9))
                {
                    OtherChar++;
                    MessageBox.Show("Invalid Pincode Number");
                    MessageBox.Show("");
                    return f = 1;
                }
            }
            if (len == 0)
            {
                MessageBox.Show("Pin code is mandatory");
                f = 1;
                return f;
            }
            else if (len < 6 && len > 6)
            {
                f = 1;
                MessageBox.Show("Invalid Pincode Number");
                return f;
            }
            else if (OtherChar != 0)
            {
                f = 1;
                MessageBox.Show("Invalid Pincode Number ");
                return f;
            }
           
            return f;

        }
        public static int CheckGender(string Gender)
        {
            int f = 0, len;
            char[] a = new char[100];
           
            a = Gender.ToCharArray();
            len = a.Length;
            if (len == 0)
            {
                f = 1;
                MessageBox.Show("Gender is mandatory");
                return f;
            }

            return f;
        }
        



    }

}
