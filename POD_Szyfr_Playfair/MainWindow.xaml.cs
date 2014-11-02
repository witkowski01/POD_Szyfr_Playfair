using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POD_Szyfr_Playfair
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Playfair playfair;
        public MainWindow()
        {
            InitializeComponent();
        }

                public Char[,] playfair_tab = new Char[5, 5] { { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' }, 
                                                        { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' } };


        

        private void set_key(string key)
        {
            
            int length = key.Length;
            bool ij = false;
            char ch = 'a';
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (k < length)
                    {
                        while (k < length)
                        {
                            if (key[k] == ' ')
                            {
                                k++;
                                continue;
                            }
                            else if(key[k]=='ą' || key[k]=='Ą')
                            {
                                if (!ij)
                                {
                                    playfair_tab[i, j] = 'i';
                                    ij = true;
                                    k++;
                                    break;
                                }
                                else
                                {
                                    k++;
                                    continue;
                                }
                            }
                            else if (key[k] == '~' || key[k] == '`' || key[k] == '!' || key[k] == '@' || key[k] == '#' || key[k] == '$' || key[k] == '%' || key[k] == '^' || key[k] == '&' || key[k] == '*'
    || key[k] == '(' || key[k] == ')' || key[k] == '-' || key[k] == '_' || key[k] == '=' || key[k] == '+' || key[k] == '[' || key[k] == ']' || key[k] == '{' || key[k] == '}'
    || key[k] == '\\' || key[k] == '|' || key[k] == ';' || key[k] == ':' || key[k] == '\'' || key[k] == '"' || key[k] == ',' || key[k] == '.' || key[k] == '<' || key[k] == '>'
    || key[k] == '/' || key[k] == '?')
                            {
                                k++;
                                continue;
                            }
                            else if (key[k] == '~' || key[k] == '`' || key[k] == '!' || key[k] == '@' || key[k] == '#' || key[k] == '$' || key[k] == '%' || key[k] == '^' || key[k] == '&' || key[k] == '*'
                               || key[k] == '(' || key[k] == ')' || key[k] == '-' || key[k] == '_' || key[k] == '=' || key[k] == '+' || key[k] == '[' || key[k] == ']' || key[k] == '{' || key[k] == '}'
                               || key[k] == '\\' || key[k] == '|' || key[k] == ';' || key[k] == ':' || key[k] == '\'' || key[k] == '"' || key[k] == ',' || key[k] == '.' || key[k] == '<' || key[k] == '>'
                               || key[k] == '/' || key[k] == '?')
                            {
                                k++;
                                continue;
                            }

                                //////////////////////////////////////////
                            //////////////////////////////////////////////
                            ////////////////////////////////////////////

                            else if (key[k] == 'i' || key[k] == 'j' || key[k] == 'I' || key[k] == 'J')
                            {
                                if (!ij)
                                {
                                    playfair_tab[i, j] = 'i';
                                    ij = true;
                                    k++;
                                    break;
                                }
                                else
                                {
                                    k++;
                                    continue;
                                }
                            }
                            else if (!checkAlfabet(key[k]))
                            {
                                playfair_tab[i, j] = key[k];
                                k++;
                                break;
                            }
                            else
                            {
                                k++;
                                continue;
                            }
                        }
                        if (playfair_tab[i, j] == ' ')
                            j--;
                    }
                    else
                    {
                        while (ch <= 'z')
                        {
                            if (ch == 'i' || ch == 'j')
                            {
                                if (!ij)
                                {
                                    playfair_tab[i, j] = 'i';
                                    ij = true;
                                    ch++;
                                    break;
                                }
                                else
                                {
                                    ch++;
                                    continue;
                                }

                            }
                            else if (!checkAlfabet(ch))
                            {
                                playfair_tab[i, j] = ch;
                                ch++;
                                break;
                            }
                            else
                            {
                                ch++;
                            }
                        }
                    }
                }
            }
        }

        public string wytnij(Char[,] alfabet, string wejscie)
        {

            var lista = new List<char>();
            foreach (char c in alfabet)
            {
                lista.Add(c);
            }
            return wejscie.Where(c => (from a in lista where a == c select a).Any()).Aggregate("", (current, c) => current + c);
        }
        private void Close(object sender, RoutedEventArgs e)  //Zamknij
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)  // Zapisz do pliku
        {
            var save = new Zapisz(wyjscie.Text);

        }
        
        
        private void Button_Click_2(object sender, RoutedEventArgs e)  // Wczytaj z pliku   
        {
            var wczyt = new Wczytaj();

           //takie coś działa
           wejscie.Text = wczyt.odczyt_zawartosci();

            //text = System.IO.File.ReadAllText(@"C:\Users\witko_000\Documents\Visual Studio 2013\Projects\Podstawy Ochrony Danych\POD_Szyfr_Playfair\POD_Szyfr_Playfair\WriteText.txt");
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)   // Deszyfrowanie
        {
           //adres_pliku_in.Text = "ghhgh";

             string key;
            key = klucz.Text;
            set_key(key);
            string input_text = wejscie.Text;
            string output_text = null;
            int m = 0;
            while (m < input_text.Length)
            {
                if (m == input_text.Length - 1)
                {
                    output_text = output_text + decrypt(input_text[m], 'x');
                    m++;
                }
                else if (input_text[m] == input_text[m + 1])
                {
                    output_text = output_text + decrypt(input_text[m], 'x');
                    m++;
                }
                else if (input_text[m] != input_text[m + 1])
                {
                    if (input_text[m] == ' ')
                    {
                        m++;
                    }
                    else if (input_text[m + 1] == ' ' && input_text[m] != input_text[m + 2])
                    {
                        output_text = output_text + decrypt(input_text[m], input_text[m + 2]);
                        m = m + 3;
                    }
                    else if (input_text[m + 1] == ' ' && input_text[m] == input_text[m + 2])
                    {
                        output_text = output_text + decrypt(input_text[m], 'x');
                        m = m + 2;
                    }
                    else
                    {
                        output_text = output_text + decrypt(input_text[m], input_text[m + 1]);
                        m = m + 2;
                    }
                }
            }
            wyjscie.Text = output_text.ToString();//playfair_tab[0, 0].ToString() + playfair_tab[0, 1].ToString() + playfair_tab[0, 2].ToString() +
            //playfair_tab[0, 3].ToString() + playfair_tab[0, 4].ToString() + playfair_tab[1, 0].ToString() + playfair_tab[1, 1].ToString() +
            //playfair_tab[1, 2].ToString() + playfair_tab[1, 3].ToString() + playfair_tab[1, 4].ToString()+playfair_tab[2, 0].ToString() +
            //playfair_tab[2, 1].ToString() + playfair_tab[2, 2].ToString() + playfair_tab[2, 3].ToString() + playfair_tab[2, 4].ToString() +
            //playfair_tab[3, 0].ToString() + playfair_tab[3, 1].ToString() + playfair_tab[3, 2].ToString() + playfair_tab[3, 3].ToString() +
            //playfair_tab[3, 4].ToString();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    playfair_tab[i, j] = ' ';
        }
        private string decrypt(char p1, char p2)    // Odszyfrowanie
        {
            string decrypt_para = null;
            

            if (check_wiersz(p1, p2))
            {
                char tmp_p1, tmp_p2;
                tmp_p1 = tmp_p2 = ' ';
                for (int i = 0; i < 5; i++)
                {
                    bool f1 = false;
                    bool f2 = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (playfair_tab[i, j] == p1 || playfair_tab[i, j] == p1 + 32 || playfair_tab[i, j] == p1 - 32)
                        {
                            if (j > 0)
                                tmp_p1 = playfair_tab[i, j - 1];
                            else
                                tmp_p1 = playfair_tab[i, j + 4];
                            f1 = true;
                        }
                        else if (playfair_tab[i, j] == p2 || playfair_tab[i, j] == p2 + 32 || playfair_tab[i, j] == p2 - 32)
                        {
                            if (j > 0)
                                tmp_p2 = playfair_tab[i, j - 1];
                            else
                                tmp_p2 = playfair_tab[i, j + 4];
                            f2 = true;
                        }
                    }
                    if (f1 && f2)
                        break;
                }
                decrypt_para = tmp_p1.ToString() + tmp_p2.ToString();
                return decrypt_para;
            }
            else if (check_kol(p1, p2))
            {
                char tmp_p1, tmp_p2;
                tmp_p1 = tmp_p2 = ' ';
                for (int i = 0; i < 5; i++)
                {
                    bool f1 = false;
                    bool f2 = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (playfair_tab[j, i] == p1 || playfair_tab[i, j] == p1 + 32 || playfair_tab[i, j] == p1 - 32)
                        {
                            if (j > 0)
                                tmp_p1 = playfair_tab[j - 1, i];
                            else
                                tmp_p1 = playfair_tab[j + 4, i];
                            f1 = true;
                        }
                        else if (playfair_tab[j, i] == p2 || playfair_tab[i, j] == p2 + 32 || playfair_tab[i, j] == p2 - 32)
                        {
                            if (j > 0)
                                tmp_p2 = playfair_tab[j - 1, i];
                            else
                                tmp_p2 = playfair_tab[j + 4, i];
                            f2 = true;
                        }
                        if (f1 && f2)
                            break;
                    }
                    if (f1 && f2)
                        break;
                }
                decrypt_para = tmp_p1.ToString() + tmp_p2.ToString();
                return decrypt_para;
            }
            else
            {
                int loc1_p1, loc2_p1, loc1_p2, loc2_p2;
                loc1_p1 = loc2_p1 = loc1_p2 = loc2_p2 = -1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (playfair_tab[i, j] == p1 || playfair_tab[i, j] == p1 + 32 || playfair_tab[i, j] == p1 - 32)
                        {
                            loc1_p1 = i;
                            loc2_p1 = j;
                        }
                        else if (playfair_tab[i, j] == p2 || playfair_tab[i, j] == p2 + 32 || playfair_tab[i, j] == p2 - 32)
                        {
                            loc1_p2 = i;
                            loc2_p2 = j;
                        }
                    }
                }
                decrypt_para = playfair_tab[loc1_p1, loc2_p2].ToString() + playfair_tab[loc1_p2, loc2_p1].ToString();
                return decrypt_para;
            }

        }
        

        private void Minimalize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        class StringValues
        {
            public string col1 { get; set; }
            public string col2 { get; set; }
            public string col3 { get; set; }
            public string col4 { get; set; }
            public string col5 { get; set; }
    
        }
        private void macierz_kluczu_na_grida()
        {

           var  klucz_do_grida = new List<StringValues>();
            for (int i = 0; i < 5; i++)
            {
                var tmp = new StringValues();
              //  var klucz = new Klucz_szyfrujacy(playfair.wartosc);
                tmp.col1 = playfair_tab[i, 0].ToString();
                tmp.col2 = playfair_tab[i, 1].ToString();
                tmp.col3 = playfair_tab[i, 2].ToString();
                tmp.col4 = playfair_tab[i, 3].ToString();
                tmp.col5 = playfair_tab[i, 4].ToString();


                klucz_do_grida.Add(tmp);
            }

            grid_klucz.ItemsSource = klucz_do_grida;

        }

        private void output(object sender, TextChangedEventArgs e)
        {

        }

        private void input_adres(object sender, TextChangedEventArgs e)
        {

        }

        private void output_adres(object sender, TextChangedEventArgs e)
        {

        }

        public string RemoveAccent(string txt)
        {

            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
          
            return System.Text.Encoding.ASCII.GetString(bytes);
           
        }

        private void Szyfrowanie_Click(object sender, RoutedEventArgs e)
        {
            
                string key;
                StringBuilder sb1 = new StringBuilder(klucz.Text);



                sb1.Replace('ą', 'a')

                  .Replace('ć', 'c')

                  .Replace('ę', 'e')

                  .Replace('ł', 'l')

                  .Replace('ń', 'n')

                  .Replace('ó', 'o')

                  .Replace('ś', 's')

                  .Replace('ż', 'z')

                  .Replace('ź', 'z')

                  .Replace('Ą', 'A')

                  .Replace('Ć', 'C')

                  .Replace('Ę', 'E')

                  .Replace('Ł', 'L')

                  .Replace('Ń', 'N')

                  .Replace('Ó', 'O')

                  .Replace('Ś', 'S')

                  .Replace('Ż', 'Z')

                  .Replace('Ź', 'Z');
            
                var result1 = sb1.ToString();
            klucz.Text = result1;
            klucz.Text.ToLower();

                key = klucz.Text;
               
                set_key(key);
            
            macierz_kluczu_na_grida();
            wejscie.Text = wejscie.Text.ToLower();
            StringBuilder sb = new StringBuilder(wejscie.Text);
            sb.Replace('j', 'i');
            var result = sb.ToString();
            wejscie.Text = result;
            wejscie.Text = RemoveAccent(wejscie.Text);
            wejscie.Text = wytnij(playfair_tab, wejscie.Text);
                string input_text = wejscie.Text;
                string output_text = null;
                int m = 0;
                while (m < input_text.Length)
                {
                    if (m == input_text.Length - 1)
                    {
                        output_text = output_text + encrypt(input_text[m], 'x');
                        m++;
                    }
                    else if (input_text[m] == input_text[m + 1])
                    {
                        output_text = output_text + encrypt(input_text[m], 'x');
                        m++;
                    }
                    else if (input_text[m] != input_text[m + 1])
                    {
                        if (input_text[m] == ' ')
                        {
                            m++;
                        }
                        else if (input_text[m + 1] == ' ' && input_text[m] != input_text[m + 2])
                        {
                            output_text = output_text + encrypt(input_text[m], input_text[m + 2]);
                            m = m + 3;
                        }
                        else if (input_text[m + 1] == ' ' && input_text[m] == input_text[m + 2])
                        {
                            output_text = output_text + encrypt(input_text[m], 'x');
                            m = m + 2;
                        }
                        else
                        {
                            output_text = output_text + encrypt(input_text[m], input_text[m + 1]);
                            m = m + 2;
                        }
                    }
                }
                wyjscie.Text = output_text.ToString();//playfair_tab[0, 0].ToString() + playfair_tab[0, 1].ToString() + playfair_tab[0, 2].ToString() +
                //playfair_tab[0, 3].ToString() + playfair_tab[0, 4].ToString() + playfair_tab[1, 0].ToString() + playfair_tab[1, 1].ToString() +
                //playfair_tab[1, 2].ToString() + playfair_tab[1, 3].ToString() + playfair_tab[1, 4].ToString() + playfair_tab[2, 0].ToString() + 
                //playfair_tab[2, 1].ToString() + playfair_tab[2, 2].ToString() + playfair_tab[2, 3].ToString() + playfair_tab[2, 4].ToString() + 
                //playfair_tab[3, 0].ToString() + playfair_tab[3, 1].ToString() + playfair_tab[3, 2].ToString() + playfair_tab[3, 3].ToString() + 
                //playfair_tab[3, 4].ToString();
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        playfair_tab[i, j] = ' ';
            }

        private string encrypt(char p1, char p2)
        {
            string encrypt_para = null;
         
            
            // Pamiątka pozostawiona z sentymenu nad czasem jaki spędziłem analizując czy to wszystkie znaki.
            /*   if (p1 == 'j')
                p1 = 'i';

            else if (p2 == 'j')
                p2 = 'i';
            else if (p1 == 'ż')
                p1 = 'z';
            else if (p2 == 'ż')
                p2 = 'z';
            else if (p1 == 'ź')
                p1 = 'z';
            else if (p2 == 'ź')
                p2 = 'z';
            else if (p1 == 'ó')
                p1 = 'o';
            else if (p2 == 'ó')
                p2 = 'o';
            else if (p1 == 'ł')
                p1 = 'l';
            else if (p2 == 'ł')
                p2 = 'l';
            else if (p1 == 'ą')
                p1 = 'a';
            else if (p2 == 'ą')
                p2 = 'a';
            else if (p1 == 'ę')
                p1 = 'e';
            else if (p2 == 'ę')
                p2 = 'e';
            else if (p1 == 'ć')
                p1 = 'c';
            else if (p2 == 'ć')
                p2 = 'c';
            else if (p1 == 'ś')
                p1 = 's';
            else if (p2 == 'ś')
                p2 = 's';
            else if (p1 == '~' || p1 == '`' || p1 == '!' || p1 == '@' || p1 == '#' || p1 == '$' || p1 == '%' || p1 == '^' || p1 == '&' || p1 == '*'
|| p1 == '(' || p1 == ')' || p1 == '-' || p1 == '_' || p1 == '=' || p1 == '+' || p1 == '[' || p1 == ']' || p1 == '{' || p1 == '}'
|| p1 == '\\' || p1 == '|' || p1 == ';' || p1 == ':' || p1 == '\'' || p1 == '"' || p1 == ',' || p1 == '.' || p1 == '<' || p1 == '>'
|| p1 == '/' || p1 == '?')
            {  p1 = 'x';}

            else if (p2 == '~' || p2 == '`' || p2 == '!' || p2 == '@' || p2 == '#' || p2 == '$' || p2 == '%' || p2 == '^' || p2 == '&' || p2 == '*'
    || p2 == '(' || p2 == ')' || p2 == '-' || p2 == '_' || p2 == '=' || p2 == '+' || p2 == '[' || p2 == ']' || p2 == '{' || p2 == '}'
    || p2 == '\\' || p2 == '|' || p2 == ';' || p2 == ':' || p2 == '\'' || p2 == '"' || p2 == ',' || p2 == '.' || p2 == '<' || p2 == '>'
    || p2 == '/' || p2 == '?')
            { p2 = 'x'; }

            */
            if (check_wiersz(p1, p2))
            {
                char tmp_p1, tmp_p2;
                tmp_p1 = tmp_p2 = ' ';
                for (int i = 0; i < 5; i++)
                {
                    bool f1 = false;
                    bool f2 = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (playfair_tab[i, j] == p1 || playfair_tab[i, j] == p1 + 32 || playfair_tab[i, j] == p1 - 32)
                        {
                            if (j < 4)
                                tmp_p1 = playfair_tab[i, j + 1];
                            else
                                tmp_p1 = playfair_tab[i, j - 4];
                            f1 = true;
                        }
                        else if (playfair_tab[i, j] == p2 || playfair_tab[i, j] == p2 + 32 || playfair_tab[i, j] == p2 - 32)
                        {
                            if (j < 4)
                                tmp_p2 = playfair_tab[i, j + 1];
                            else
                                tmp_p2 = playfair_tab[i, j - 4];
                            f2 = true;
                        }
                    }
                    if (f1 && f2)
                        break;
                }
                encrypt_para = tmp_p1.ToString() + tmp_p2.ToString();
                return encrypt_para;
            }
            else if (check_kol(p1, p2))
            {
                char tmp_p1, tmp_p2;
                tmp_p1 = tmp_p2 = ' ';
                for (int i = 0; i < 5; i++)
                {
                    bool f1 = false;
                    bool f2 = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (playfair_tab[j, i] == p1 || playfair_tab[i, j] == p1 + 32 || playfair_tab[i, j] == p1 - 32)
                        {
                            if (j < 4)
                                tmp_p1 = playfair_tab[j + 1, i];
                            else
                                tmp_p1 = playfair_tab[j - 4, i];
                            f1 = true;
                        }
                        else if (playfair_tab[j, i] == p2 || playfair_tab[i, j] == p2 + 32 || playfair_tab[i, j] == p2 - 32)
                        {
                            if (j < 4)
                                tmp_p2 = playfair_tab[j + 1, i];
                            else
                                tmp_p2 = playfair_tab[j - 4, i];
                            f2 = true;
                        }
                        if (f1 && f2)
                            break;
                    }
                    if (f1 && f2)
                        break;
                }
                encrypt_para = tmp_p1.ToString() + tmp_p2.ToString();
                return encrypt_para;
            }
            else
            {
                int loc1_p1, loc2_p1, loc1_p2, loc2_p2;
                loc1_p1 = loc2_p1 = loc1_p2 = loc2_p2 = -1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (playfair_tab[i, j] == p1 || playfair_tab[i, j] == p1 + 32 || playfair_tab[i, j] == p1 - 32)
                        {
                            loc1_p1 = i;
                            loc2_p1 = j;
                        }
                        else if (playfair_tab[i, j] == p2 || playfair_tab[i, j] == p2 + 32 || playfair_tab[i, j] == p2 - 32)
                        {
                            loc1_p2 = i;
                            loc2_p2 = j;
                        }
                    }
                }
                encrypt_para = playfair_tab[loc1_p1, loc2_p2].ToString() + playfair_tab[loc1_p2, loc2_p1].ToString();
                return encrypt_para;
            }

        }



        private bool checkAlfabet(char alfabet)
        {
            bool found = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (playfair_tab[i, j] == alfabet || playfair_tab[i, j] == alfabet + 32 || playfair_tab[i, j] == alfabet - 32)
                        found = true;
                }
            }
            if (found)
                return true;
            else
                return false;
        }
        private bool check_wiersz(char p1, char p2)
        {
            bool found = false;
            for (int i = 0; i < 5; i++)
            {
                bool flag1 = false;
                bool flag2 = false;
                for (int j = 0; j < 5; j++)
                {
                    if (playfair_tab[i, j] == p1)
                        flag1 = true;
                    else if (playfair_tab[i, j] == p2)
                        flag2 = true;

                }
                if (flag1 && flag2)
                {
                    found = true;
                    break;
                }
                else
                    continue;
            }
            return found;
        }

        private bool check_kol(char p1, char p2)
        {
            bool found = false;
            for (int i = 0; i < 5; i++)
            {
                bool flag1 = false;
                bool flag2 = false;
                for (int j = 0; j < 5; j++)
                {
                    if (playfair_tab[j, i] == p1 || playfair_tab[j, i] == p1 + 32 || playfair_tab[j, i] == p1 - 32)
                        flag1 = true;
                    else if (playfair_tab[j, i] == p2 || playfair_tab[j, i] == p2 + 32 || playfair_tab[j, i] == p2 - 32)
                        flag2 = true;

                }
                if (flag1 && flag2)
                {
                    found = true;
                }
                else
                    continue;
            }
            return found;
        }

        private void key(object sender, TextChangedEventArgs e)
        {

        }

        private void input(object sender, TextChangedEventArgs e)
        {

        }

        private void Instrukcja(object sender, RoutedEventArgs e)
        {
            var i = new Instrukcja();
            i.Show();
        }



    }
}
