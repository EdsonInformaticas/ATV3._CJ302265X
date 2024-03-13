namespace ATV3_CJ302265X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ATV3 projeto1
            Console.WriteLine("Digite um numero inteiro");
            int nmr = int.Parse(Console.ReadLine());
            if (nmr % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else Console.WriteLine("O numero é impar");

            //ATV3 projeto2

            Console.WriteLine("Digite os lados de um triangulo, em linhas separadas");
            float lado = float.Parse(Console.ReadLine());
            float lado2 = float.Parse(Console.ReadLine());
            float lado3 = float.Parse(Console.ReadLine());
            if ((lado == lado2) && (lado != lado3) || (lado2 == lado3) && (lado2 != lado) || (lado == lado3) && (lado != lado2))
            {
                Console.WriteLine("O triangulo é isoceles");

            }
            if ((lado == lado3) && (lado2 == lado3))
            {
                Console.WriteLine("O triangulo é equilatero");
            }
            if ((lado != lado2) && (lado2 != lado3) && (lado != lado3))
            {
                Console.WriteLine("O trianguo é escaleno");
            }

            int chance1, chance2, chance3;
            Random random = new Random();
            int min = 1;
            int max = 100;
            int numeroAleatorio = random.Next(min, max + 1);
            Console.WriteLine("Adivinhe o número");
            chance1 = int.Parse(Console.ReadLine());
            if (chance1 > numeroAleatorio)
            {
                Console.WriteLine("O número aleatorio é menor");
            }
            else if (chance1 == numeroAleatorio)
            {
                Console.WriteLine("Você acertou");
                return;
            }
            else
            {
                Console.WriteLine("O número é maior");
            }
            chance2 = int.Parse(Console.ReadLine());
            if (chance2 > numeroAleatorio)
            {
                Console.WriteLine("O número aleatorio é menor");
            }
            else if (chance2 == numeroAleatorio)
            {
                Console.WriteLine("Você acertou");
                return;
            }
            else
            {
                Console.WriteLine("O número é maior");

            }
                chance3 = int.Parse(Console.ReadLine());
                if (chance3 > numeroAleatorio)
                {
                    Console.WriteLine("O número aleatorio é menor");
                }
                else if (chance3 == numeroAleatorio)
                {
                    Console.WriteLine("Você acertou");
                    return;
                }
                else
                {
                    Console.WriteLine("O número é maior");
                }

            //ATV3 projeto4

            Console.WriteLine("Coloque o nome: ");
            Console.WriteLine("Coloque a senha: ");
            string nome = Console.ReadLine();
            string senha = Console.ReadLine();
            if ((nome == "admin") && (senha == "admin123"))
            {
                Console.WriteLine("Acesso Concedido");

            }
            else Console.WriteLine("Acesso negado");


            //ATV3 projeto5
            Console.WriteLine("Digite a nota de 0 a 100");
            int nota = int.Parse(Console.ReadLine());
            if ((nota <= 100) && (nota >= 90))
            {
                Console.WriteLine("Sua nota é A");
            }
            if ((nota <= 89) && (nota >= 80))
            {
                Console.WriteLine("Sua nota é B");
            }
            if ((nota <= 79) && (nota >= 70))
            {
                Console.WriteLine("Sua nota é C");
            }
            if ((nota <= 69) && (nota >= 60))
            {
                Console.WriteLine("Sua nota é D");
            }
            if (nota < 60)
            {
                Console.WriteLine("Sua nota é F");
            }

            //ATV3 projeto7

            Console.WriteLine("Digite o valor do produto");
            int produto = int.Parse(Console.ReadLine());
            if ((produto > 100) && (produto < 200))
            {
                int produto2 = (((produto / 100) * 10) - produto);
                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de ", produto2);
            }
            if ((produto > 200) && (produto < 300))
            {
                int produto3 = (((produto / 100) * 20) - produto);
                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de ", produto3);
            }
            if ((produto > 300) && (produto < 400))
            {
                int produto4 = (((produto / 100) * 30) - produto);
                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de", produto4);
            }
            if (produto > 400)
            {
                int produto5 = (((produto / 100) * 40) - produto);
                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de", produto5);
            }

            //ATV3 projeto8
            Console.WriteLine("Digite o seu peso em kg");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura em metros");
            float altura = float.Parse(Console.ReadLine());
            float imc = (peso / (altura * altura));
            if (imc < 18.5)
            {
                Console.WriteLine("Voce está abaixo do peso");
            }
            if ((imc > 18.5) && (imc < 24.9))
            {
                Console.WriteLine("Voce está no peso normal");
            }
            if ((imc > 24.9) && (imc < 29.9))
            {
                Console.WriteLine("Voce está no sobrepeso");
            }
            if ((imc > 30) && (imc < 34.9))
            {
                Console.WriteLine("Voce esta na obesidade grau I");
            }
            if ((imc > 34.9) && (imc < 39.9))
            {
                Console.WriteLine("Voce esta na obesidade grau II");
            }
            if (imc > 40)
            {
                Console.WriteLine("Voce esta na obesidade grau III");
            }


        }
        }
    }


