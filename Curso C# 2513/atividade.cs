using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C__2513
{
    using System;

    class Program
    {
        
       

        static void Main()
        {
            //LerArmazenar();
            // Lernomeidade();
            //LernomeEcidade();
            //lerNomeMaiusculo();
            //lerNomeMinusculo();
            //LernomeidadeUni();
            //LernomeidadeUni();
            //LernomeidadeUni();
            //LernomeEprofissão();
            //LernomeEpaisorig();
            //LernomeEnumerofav();
            //LernomeEhobbyfav;
            //NomeEcorfav();
            //LernomeEmusicafav();
            //lerNomeEanimalfav();
            //lerNomeEesportefav();
            //lerNomeEcomidafav();
            //lerNomeEbandafav();
            //lerLivrofav();
            lemafav();
        }

        /*
        Modifique o método LerArmazenar para armazenar o sobrenome do usuário e
        exibi-lo junto com o nome:
        
        static void LerArmazenar()
        {
            Console.Write("Digite seu nome: ");
          
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
           
            Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        }
    */

        /*
        Peça ao usuário para inserir a idade e exiba o nome e a idade:
        static void Lernomeidade()
        {
            string idade;
            string nome;

            Console.Write("Por favor, insira o seu nome: ");
             nome = Console.ReadLine();


            Console.Write("Por favor, insira a sua idade: ");
            idade = Console.ReadLine();


            Console.WriteLine($"Nome: {nome}, Idade: {idade} anos");
        */

        //Peça ao usuário para inserir a cidade e exiba o nome e a cidade:
        /*
        static void LernomeEcidade()
        {
          string nome
          string cidade

            Console.Write("Por favor, insira o seu nome: ");
            nome = Console.ReadLine();


            Console.Write("Por favor, insira a sua cidade: ");
            cidade = Console.ReadLine();


            Console.WriteLine($"Nome: {nome}, Cidade: {cidade}");
        }
        */
        //Armazene o nome do usuário em maiúsculas e exiba-o:
        /*   static void lerNomeMaiusculo()
           {
               string nome;

               Console.Write("Por favor, insira o seu nome: ");
                nome = Console.ReadLine().ToUpper(); 

               Console.WriteLine($"Nome em maiúsculas: {nome}");
           }
        */

        //Armazene o nome do usuário em minúsculas e exiba-o:

        /* static void lerNomeMinusculo()
             {
                 string nome;

                 Console.Write("Por favor, insira o seu nome: ");
                  nome = Console.ReadLine().ToLower(); 

                 Console.WriteLine($"Nome em maiúsculas: {nome}");
             }
        */

        //Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma
        //única linha:
        /* static void LernomeidadeUni()
         {
             string nome;
             string idade;

             Console.Write("Por favor, insira o seu nome: ");
              nome = Console.ReadLine();

             Console.Write("Por favor, insira a sua idade: ");
             idade = Console.ReadLine();

             Console.WriteLine($"O seu nome é: {nome} e a sua idade é: {idade}");
         }
        */

        //Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba
        //ambos:

        /*  static void LernomeidadeUni()
          {

              string nome;
              string cidade;

              Console.Write("Por favor, insira o seu nome: ");
              nome = Console.ReadLine();

              Console.Write("Por favor, insira a sua cidade de nascimento: ");
              cidade = Console.ReadLine();

              Console.WriteLine($"O seu nome é: {nome} e a sua idade é: {cidade}");
          }
        */
        //Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:
        /*
        static void LernomeEprofissão()
        {
            string nome;
            string profissao;

            Console.Write("Por favor, insira o seu nome: ");
             nome = Console.ReadLine();


            Console.Write("Por favor, insira a sua profissão: ");
            profissao = Console.ReadLine();


            Console.WriteLine($"Nome: {nome}, Profissão: {profissao}");
        }
        */
        //Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:
        /*static void LernomeEpaisorig()
        {
            string nome;
            string pais;

                Console.Write("Por favor, insira o seu nome: ");
             nome = Console.ReadLine();


            Console.Write("Por favor, insira o seu país de origem: ");
             pais = Console.ReadLine();


            Console.WriteLine($"Nome: {nome}, País de origem: {pais}");
        }

        */
        //Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:

        /*
        static void LernomeEnumerofav()
        {
            string numeroFavorito;
            string nome;

            Console.Write("Por favor, insira o seu nome: ");
            nome = Console.ReadLine();


            Console.Write("Por favor, insira o seu número favorito: ");
            numeroFavorito = Console.ReadLine();


            Console.WriteLine($"Nome: {nome}, Número favorito: {numeroFavorito}");
        }
        */
        //Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:
        /*static void LernomeEhobbyfav()
        {
            string nome;
            string hobbyFavorito;

             Console.Write("Por favor, insira o seu nome: ");
             nome = Console.ReadLine();


            Console.Write("Por favor, insira o seu hobby favorito: ");
            hobbyFavorito = Console.ReadLine();


            Console.WriteLine($"Nome: {nome}, Hobby favorito: {hobbyFavorito}");
        }
        */
        //Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:

        /*
         static void NomeEcorfav()
         {
             string nome;
             string corFavorita;
             Console.Write("Por favor, insira o seu nome: ");
              nome = Console.ReadLine();


             Console.Write("Por favor, insira a sua cor favorita: ");
             corFavorita = Console.ReadLine();


             Console.WriteLine($"Nome: {nome}, Cor favorita: {corFavorita}");
         }
        */
        //Peça ao usuário para inserir seu nome e gênero musical favorito, depois exiba
        //ambos:
        /*
         static void LernomeEmusicafav()
         {
             string nome;
             string generoMusicalFavorito;
             Console.Write("Por favor, insira o seu nome: ");
              nome = Console.ReadLine();


             Console.Write("Por favor, insira o seu gênero musical favorito: ");
             generoMusicalFavorito = Console.ReadLine();


             Console.WriteLine($"Nome: {nome}, Gênero musical favorito: {generoMusicalFavorito}");
         }
        */

        //Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:

        /*
        static void lerNomeEanimalfav()
        {
            string nome;
            string animalFavorito;


            Console.Write("Por favor, insira o seu nome: ");
             nome = Console.ReadLine();

            
            Console.Write("Por favor, insira o seu animal favorito: ");
            animalFavorito = Console.ReadLine();

            
            Console.WriteLine($"Nome: {nome}, Animal favorito: {animalFavorito}");
        }
    */
        //Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:

        /*static void lerNomeEesportefav()
        {
            string nome;
            string esporteFavorito;


            Console.Write("Por favor, insira o seu nome: ");
             nome = Console.ReadLine();

         
            Console.Write("Por favor, insira o seu esporte favorito: ");
            esporteFavorito = Console.ReadLine();

           
            Console.WriteLine($"Nome: {nome}, Esporte favorito: {esporteFavorito}");
        }
*/
        //Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:

        /* static void lerNomeEcomidafav()
        {
            
            Console.Write("Por favor, insira o seu nome: ");
            string nome = Console.ReadLine();

           
            Console.Write("Por favor, insira a sua comida favorita: ");
            string comidaFavorita = Console.ReadLine();

           
            Console.WriteLine($"Nome: {nome}, Comida favorita: {comidaFavorita}");
        }
       */

        //Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:

        /* static void lerNomeEbandafav()
         {
             Console.Write("Por favor, insira o seu nome: ");
             string nome = Console.ReadLine();


             Console.Write("Por favor, insira a sua banda favorita: ");
             string bandaFavorita = Console.ReadLine();


             Console.WriteLine($"Nome: {nome}, Banda favorita: {bandaFavorita}");
         }
     */
        //Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:
        /*static void lerLivrofav()
        {
           
            Console.Write("Por favor, insira o seu nome: ");
            string nome = Console.ReadLine();

         
            Console.Write("Por favor, insira o seu livro favorito: ");
            string livroFavorito = Console.ReadLine();

        
            Console.WriteLine($"Nome: {nome}, Livro favorito: {livroFavorito}");
        }
        */
        // Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:

        static void lemafav()
        {
            
            Console.Write("Por favor, insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Por favor, insira o seu lema de vida: ");
            string lemaDeVida = Console.ReadLine();

           
            Console.WriteLine($"Nome: {nome}, Lema de vida: {lemaDeVida}");
        }
    }
}



