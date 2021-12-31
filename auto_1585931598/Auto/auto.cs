using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Auto
{
    enum Types {Int,Double,String };
    public class auto
    {
        private int _num1;
        private double _num2;
        private string _num3;
        private Types _types;
        public auto(int num){
            _num1 = num;
            _types = Types.Int;
        }
        public auto(double num){
            _num2 = num;
            _types = Types.Double;
        }
        public auto(string num){
            _num3 = num;
            _types = Types.String;
        }
        public string Tostring()
        { if (_num1 != 0)
                return $"Result: {_num1} ";
            else if (_num2 != 0)
                return $"Result: {_num2} ";
            else return $"Result: {_num3}";
        }
        public static auto operator+(auto l, auto r)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 + (int)r);
            else if (l._types == Types.Double)
                return new auto(l._num2 + (double)r);
            else return new auto(l._num3 + (string)r);
        }
        public static auto operator +(auto l, int s)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 + s);
            else if (l._types == Types.Double)
                return new auto(l._num2 + s);
            else return new auto(l._num3 + s);
        }
        public static auto operator +(int s, auto l)
        {
            if (l._types == Types.Int)
                return new auto(s + l._num1);
            else if (l._types == Types.Double)
                return new auto(s + l._num2);
            else
            {
                bool res = int.TryParse(l._num3, out int m);
                if (res == true)
                    return new auto(s + m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator +(auto l, double s)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 + s);
            else if (l._types == Types.Double)
                return new auto(l._num2 + s);
            else return new auto(l._num3 + s);
        }
        public static auto operator +(double s, auto l)
        {
            if (l._types == Types.Int)
                return new auto(s + l._num1);
            else if (l._types == Types.Double)
                return new auto(s + l._num2);
            else
            {
                bool res = double.TryParse(l._num3, out double m);
                if (res == true)
                    return new auto(s + m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator +(auto l, string s)//
        {
            if (l._types == Types.Int)
            {
                bool res = int.TryParse(s, out int m);
                if (res == true)
                    return new auto(l._num1 + m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else if (l._types == Types.Double)
            {
                bool res = double.TryParse(s, out double m);
                if (res == true)
                    return new auto(l._num2 + m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else return new auto(l._num3 + s);
        }
        public static auto operator +(string str, auto l)
        {
            if (l._types == Types.Int)
                throw new FormatException("Convertion has not passed successfuly");
            else if (l._types == Types.Double)
                throw new FormatException("Convertion has not passed successfuly");
            else return new auto(str + l._num3);
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static auto operator -(auto l, auto r)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 - (int)r);
            else if (l._types == Types.Double)
                return new auto(l._num2 - (double)r);
            else throw new FormatException("The operation can't be applied."); 
        }
        public static auto operator -(auto l, int s)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 - s);
            else if (l._types == Types.Double)
                return new auto(l._num2 - s);
            else throw new FormatException("The operation is not alloved");
           // return new auto(l._num3 + s);
        }
        public static auto operator -(int s, auto l)
        {
            if (l._types == Types.Int)
                return new auto(s - l._num1);
            else if (l._types == Types.Double)
                return new auto(s - l._num2);
            else
            {
                bool res = int.TryParse(l._num3, out int m);
                if (res == true)
                    return new auto(s - m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator -(auto l, double s)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 - s);
            else if (l._types == Types.Double)
                return new auto(l._num2 - s);
            else throw new FormatException("The operation is not alloved");
        }
        public static auto operator -(double s, auto l)
        {
            if (l._types == Types.Int)
                return new auto(s - l._num1);
            else if (l._types == Types.Double)
                return new auto(s - l._num2);
            else
            {
                bool res = double.TryParse(l._num3, out double m);
                if (res == true)
                    return new auto(s - m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator -(auto l, string s)
        {
            if (l._types == Types.Int)
            {
                bool res = int.TryParse(s, out int m);
                if (res == true)
                    return new auto(l._num1 - m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else if (l._types == Types.Double)
            {
                bool res = double.TryParse(s, out double m);
                if (res == true)
                    return new auto(l._num2 - m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else throw new FormatException("The operation can't be applied.");
        }
        public static auto operator -(string str, auto l)
        {
            throw new FormatException("The operation can't be applied.");
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static auto operator *(auto l, auto r)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 * (int)r);
            else if (l._types == Types.Double)
                return new auto(l._num2 * (double)r);
            else 
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < l._num3.Length; i++)
                {
                    for (int j = 0; j < r._num3.Length; j++)
                    {
                        if (l._num3[i] == r._num3[j])
                        {
                            str.Append(l._num3[i]);
                            break;
                        }
                    }
                }
                return new auto(str.ToString());
            }
                throw new FormatException("The operation is not alloved");
        }
        public static auto operator *(auto l, int s)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 * s);
            else if (l._types == Types.Double)
                return new auto(l._num2 * s);
            else throw new FormatException("The operation is not alloved");
        }
        public static auto operator *(int s, auto l)
        {
            if (l._types == Types.Int)
                return new auto(s * l._num1);
            else if (l._types == Types.Double)
                return new auto(s * l._num2);
            else
            {
                bool res = int.TryParse(l._num3, out int m);
                if (res == true)
                    return new auto(s * m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator *(auto l, double s)
        {
            if (l._types == Types.Int)
                return new auto(l._num1 * s);
            else if (l._types == Types.Double)
                return new auto(l._num2 * s);
            else throw new FormatException("The operation is not alloved");
        }
        public static auto operator *(double s, auto l)
        {
            if (l._types == Types.Int)
                return new auto(s * l._num1);
            else if (l._types == Types.Double)
                return new auto(s * l._num2);
            else
            {
                bool res = double.TryParse(l._num3, out double m);
                if (res == true)
                    return new auto(s * m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator *(auto l, string s)
        {
            if (l._types == Types.Int)
            {
                bool res = int.TryParse(s, out int m);
                if (res == true)
                    return new auto(l._num1 * m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else if (l._types == Types.Double)
            {
                bool res = double.TryParse(s, out double m);
                if (res == true)
                    return new auto(l._num2 * m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else 
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < l._num3.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (l._num3[i] == s[j])
                        {
                            str.Append(l._num3[i]);
                            break;
                        }
                    }
                }
                return new auto(str.ToString());
            }
        }
        public static auto operator *(string st, auto l)
        {
            if (l._types == Types.String)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < st.Length; i++)
                {
                    for (int j = 0; j < l._num3.Length; j++)
                    {
                        if (st[i] == l._num3[j])
                        {
                            str.Append(l._num3[j]);
                            break;
                        }
                    }
                }
                return new auto(str.ToString());
            }
            else throw new FormatException("The operation can't be applied.");
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static auto operator /(auto l, auto r)
        {
            if (l._types == Types.Int)
            {
                if ((int)r != 0)
                    return new auto(l._num1 / (int)r);
                else throw new DivideByZeroException();
            }
            else if (l._types == Types.Double)
            {
                if ((double)r != 0)
                    return new auto(l._num2 / (double)r);
                else throw new DivideByZeroException();
            }
            else                                
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < l._num3.Length; i++)
                {
                    for (int j = 0; j < r._num3.Length; j++)
                    {
                        if (l._num3[i] == r._num3[j])
                            break;
                        if (l._num3[i] != r._num3[j] && j == r._num3.Length - 1)
                            str.Append(l._num3[i]);
                    }
                }
                return new auto(str.ToString());
            }
        }
        public static auto operator /(auto l, int s)
        {
            if (s==0)
                 throw new DivideByZeroException();
            if (l._types == Types.Int)
                return new auto(l._num1 / s);
            else if (l._types == Types.Double)
                return new auto(l._num2 / s);
            else throw new FormatException("The operation is not alloved");
        }
        public static auto operator /(int s, auto l)
        {
            if (l._types == Types.Int)
            {
                if (l._num1 == 0)
                    throw new DivideByZeroException();
                return new auto(s / l._num1);
            }
            else if (l._types == Types.Double)
            {if(l._num2==0)
                   throw new DivideByZeroException();
                return new auto(s / l._num2); }
            else
            {
                bool res = int.TryParse(l._num3, out int m);
                if (res == true&&m!=0)
                    return new auto(s / m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator /(auto l, double s)
        {
            if (s==0)  throw new DivideByZeroException();
            if (l._types == Types.Int)
                return new auto(l._num1 / s);
            else if (l._types == Types.Double)
                return new auto(l._num2 / s);
            else throw new FormatException("The operation is not alloved");
        }
        public static auto operator /(double s, auto l)
        {
            if (l._types == Types.Int)
            {
                if (l._num1 == 0)
                    throw new DivideByZeroException();
                return new auto(s / l._num1);
            }
            else if (l._types == Types.Double)
            {
                if (l._num2 == 0)
                    throw new DivideByZeroException();
                return new auto(s / l._num2); }
            else
            {
                bool res = double.TryParse(l._num3, out double m);
                if (res == true&&m!=0)
                    return new auto(s / m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static auto operator /(auto l, string s)
        {
            if (l._types == Types.Int)
            {
                bool res = int.TryParse(s, out int m);
                if (res == true&&m!=0)
                    return new auto(l._num1 / m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else if (l._types == Types.Double)
            {
                bool res = double.TryParse(s, out double m);
                if (res == true&&m!=0)
                    return new auto(l._num2 / m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < l._num3.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (l._num3[i] == s[j])
                            break;
                        if (l._num3[i] != s[j] && j == s.Length - 1)
                            str.Append(l._num3[i]);
                    }
                }
                return new auto(str.ToString());      
            }
        }
        public static auto operator /(string st, auto l)
        {
            if (l._types == Types.String)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < st.Length; i++)
                {
                    for (int j = 0; j < l._num3.Length; j++)
                    {
                        if (st[i] == l._num3[j])
                            break;
                        if (st[i] != l._num3[j] && j == l._num3.Length - 1)
                            str.Append(st[i]);
                    }
                }
                return new auto(str.ToString());
            }
            else throw new FormatException("The operation can't be applied.");
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static bool operator <(auto l, auto r)
        {
            if (l._types == Types.Int)              
                return (l._num1 < (int)r); 
            else if (l._types == Types.Double)
                return (l._num2 < (double)r);
            else throw new FormatException("The operation can't be applied.");
        }
        public static bool operator <(auto l, int s)
        {
            if (l._types == Types.Int)
                return (l._num1 < s);
            else if (l._types == Types.Double)
                return (l._num2 < s);
            else throw new FormatException("The operation is not alloved");
        }
        public static bool operator <(int s, auto l)
        {
            if (l._types == Types.Int)  return (s < l._num1);
            else if (l._types == Types.Double)  return (s < l._num2);
            else
            {
                bool res = int.TryParse(l._num3, out int m);
                if (res == true)
                    return (s < m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static bool operator <(auto l, double s)
        {
            if (l._types == Types.Int) return (l._num1 < s);
            else if (l._types == Types.Double)
                return (l._num2 < s);
            else throw new FormatException("The operation is not alloved");
        }
        public static bool operator <(double s, auto l)
        {
            if (l._types == Types.Int)   return (s < l._num1);
            else if (l._types == Types.Double)
            {
                return(s < l._num2);
            }
            else
            {
                bool res = double.TryParse(l._num3, out double m);
                if (res == true)
                    return (s < m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static bool operator <(auto l, string s)
        {
            if (l._types == Types.Int)
            {
                bool res = int.TryParse(s, out int m);
                if (res == true)
                    return (l._num1 < m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else if (l._types == Types.Double)
            {
                bool res = double.TryParse(s, out double m);
                if (res == true)
                    return (l._num2 < m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else throw new FormatException("The operation can't be applied.");
        }
        public static bool operator <(string st, auto l)
        {
            throw new FormatException("The operation can't be applied.");
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static bool operator >(string st, auto l)
        {
            throw new FormatException("The operation can't be applied.");
        }
        public static bool operator >(auto l, string s)
        {
            return !(l > s);
        }
        public static bool operator >(double s, auto l)
        {
            return !(s < l);
        }
        public static bool operator >(auto l, double s)
        {
            return !(l < s);
        }
        public static bool operator >(int s, auto l)
        {
            return !(s < l);
        }
        public static bool operator >(auto l, int s)
        {
            return !(l < s);
        }
        public static bool operator >(auto l, auto r)
        {
            return !(l < r);
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static bool operator ==(auto l, auto r)
        {
            if (l._types == Types.Int)
                return (l._num1 == (int)r);
            else if (l._types == Types.Double)
                return (l._num2 == (double)r);
            else if (r._types == Types.String)
                return ((l._num3 == r._num3));
            else throw new FormatException();
        }
        public static bool operator ==(auto l, int s)
        {
            if (l._types == Types.Int)
                return (l._num1 == s);
            else if (l._types == Types.Double)
                return(l._num2 == s);
            else throw new FormatException("The operation is not alloved");
        }
        public static bool operator ==(int s, auto l)
        {
            if (l._types == Types.Int) return (s == l._num1);
            else if (l._types == Types.Double) return (s == l._num2);
            else
            {
                bool res = int.TryParse(l._num3, out int m);
                if (res == true)
                    return (s == m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static bool operator ==(auto l, double s)
        {
            if (l._types == Types.Int) return (l._num1 == s);
            else if (l._types == Types.Double)
                return (l._num2 == s);
            else throw new FormatException("The operation is not alloved");
        }
        public static bool operator ==(double s, auto l)
        {
            if (l._types == Types.Int) return (s == l._num1);
            else if (l._types == Types.Double)
            {
                return (s == l._num2);
            }
            else
            {
                bool res = double.TryParse(l._num3, out double m);
                if (res == true)
                    return (s == m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static bool operator ==(auto l, string s)
        {
            if (l._types == Types.Int)
            {
                bool res = int.TryParse(s, out int m);
                if (res == true)
                    return (l._num1 == m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else if (l._types == Types.Double)
            {
                bool res = double.TryParse(s, out double m);
                if (res == true)
                    return (l._num2 == m);
                else throw new FormatException("Convertion has not passed successfuly");
            }
            else
            {
                return l._num3 == s;
            }
        }
        public static bool operator ==(string st, auto l)
        {
            if (l._types == Types.String)
                return st == l._num3;
            else throw new FormatException("The operation is not alloved");
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static bool operator !=(string st, auto l)
        {
            if (l._types == Types.String)
                return st != l._num3;
            else throw new FormatException("The operation is not alloved");
        }
        public static bool operator !=(auto l, string s)
        {
            return !(l == s);
        }
        public static bool operator !=(double s, auto l)
        {
            return !(s == l);
        }
        public static bool operator !=(auto l, double s)
        {
            return !(l == s);
        }
        public static bool operator !=(int s, auto l)
        {
            return !(s == l);
        }
        public static bool operator !=(auto l, int s)
        {
            return !(l == s);
        }
        public static bool operator !=(auto l, auto r)
        {
            return !(l == r);
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static bool operator <=(auto l, auto r)
        {
            if (l < r)
                return l < r;
            else return l == r;
        }
        public static bool operator <=(auto l, string s)
        {
            if (l < s) return l < s;
            else return (l == s);
        }
        public static bool operator <=(int s, auto l)
        {
            if (s < l) return s < l;
            else return s == l;
        }
        public static bool operator <=(auto l, double s)
        {
            if (l < s) return l < s;
            else return l == s;
        }
        public static bool operator <=(double s, auto l)
        {
            if (s < l) return s < l;
            else return s == l;
        }
        public static bool operator <=(auto l, int s)
        {
            if (l < s) return l < s;
            else return l == s;
        }
        public static bool operator <=(string st, auto l)
        {
            if (st < l) return st < l;
            else return st == l;
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static bool operator >=(string st, auto l)
        {
            if (st > l) return st > l;
            else return st == l;
        }
        public static bool operator >=(auto l, int s)
        {
            if (l > s) return l > s;
            else return l == s;
        }
        public static bool operator >=(double s, auto l)
        {
            if (s > l) return s > l;
            else return s == l;
        }
        public static bool operator >=(auto l, double s)
        {
            if (l > s) return l > s;
            else return l == s;
        }
        public static bool operator >=(int s, auto l)
        {
            if (s >l) return s > l;
            else return s == l;
        }
        public static bool operator >=(auto l, string s)
        {
            if (l > s) return l > s;
            else return (l == s);
        }
        public static bool operator >=(auto l, auto r)
        {
            return !(l <= r);
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static explicit operator int(auto obj)
        { if (obj._types == Types.Int)
                return obj._num1;
            else if (obj._types == Types.Double)
                 return (int ) obj._num2;
            else
            {
                bool res = int.TryParse(obj._num3, out int m);
                if (res == true)
                    return m;
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static explicit operator double(auto obj)
        {
            if (obj._types == Types.Int)
                return obj._num1;
            else if (obj._types == Types.Double)
                return obj._num2;
            else
            {
                bool res = double.TryParse(obj._num3, out double m);
                if (res == true)
                    return m;
                else throw new FormatException("Convertion has not passed successfuly");
            }
        }
        public static explicit operator string(auto obj)
        {
            return obj.ToString();
        }
        public static auto operator ++(auto obj)
        {
            if (obj._types == Types.Int)
            {
                obj._num1++;
                return obj;
            }else if (obj._types == Types.Double)
            {
                obj._num2++;
                return obj;
            }
            else throw new FormatException("The operation can't be applied.");
        }
        public static auto operator --(auto obj)
        {
            if (obj._types == Types.Int)
            {
                obj._num1--;
                return obj;
            }else if (obj._types == Types.Double)
            {
                obj._num2--;
                return obj;
            }
            else throw new FormatException("The operation can't be applied.");
        }
    }
 }
