//
using System;

namespace lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de média, mediana e moda de um Array");
            double[] arr = {123, 412, 543 , 7567, 3,500,1234 };
            Console.WriteLine("Média: " + calculaMedia(arr));
            Console.WriteLine("Mediana: " + calculaMediana(arr));
            if(calculaModa(arr) == 0){
                Console.WriteLine("Moda: Não possui moda");
            }else{
                Console.WriteLine("Moda: " + calculaModa(arr));
            }
            
            
        }

        static double calculaMedia(double[] nums){
            double media = 0;
            for(int i=0;i < nums.Length; i++){
                media += nums[i];
            }
            media = media/nums.Length;
            return media;
        }

         static double calculaMediana(double[] nums){
            double mediana = 0;
            bool isImpar = false; 
            Array.Sort(nums);
            if(nums.Length % 2 != 0){
                isImpar = true;
            }

            if(isImpar){
                int posicao = (nums.Length + 1 ) / 2;
                mediana = nums[posicao -1];
            }else{
                int posicao1 = (nums.Length / 2);
                int posicao2 = (nums.Length / 2) + 1;

                mediana = (nums[posicao1 - 1] + nums[posicao2 - 1]) / 2;
            }
            return mediana;
        }    

         static double calculaModa(double[] nums){
            double moda = 0;
            double conta = 0;
            double[] auxV = new double[nums.Length];
            for(int i=0;i<nums.Length;i++){
                for(int j=i+1;j<nums.Length;j++){
                    
                    if(nums[i] == nums[j]){
                        auxV[i]++;
                            if(auxV[i]>conta){
                                conta=auxV[i];
                                moda=nums[i];
                            }
                    }
                    
                }
                auxV[i]=0;
            }
            return moda;
        }
    }
}