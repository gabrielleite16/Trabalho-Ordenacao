using System;
using System.Diagnostics;

namespace TrabalhoOrdenacaoGabriel318122246
{
    class Program
    {
        /* CRIAR VETOR DECRESCENTE */
        static int[] vetordecrescente(int grandeza)
        {
            int[] resultado = new int[grandeza];

            for (int z = 0; z < resultado.Length; z++)
            {

                resultado[z] = grandeza;
                grandeza = grandeza - 1;

            }

            return resultado;
        }

        /* CRIAR VETOR CRESCENTE */
        static int[] vetorcrescente(int grandeza)
        {
            int[] resultado2 = new int[grandeza];
            for (int i = 0; i < resultado2.Length; i++)
            {
                resultado2[i] = i;

            }

            return resultado2;
        }

        /* CRIAR VETOR RANDOMICO */
        static int[] vetorrandomico(int grandeza)
        {
            int[] resultado3 = new int[grandeza];

            Random aleatorio = new Random();
            for (int j = 0; j < resultado3.Length; j++)
            {
                resultado3[j] = aleatorio.Next(0, 10000); 
            }

            return resultado3;
        }

        /* MÉTODO BUBBLE SORT */
        static int[] bubbleSort(int[] resultado4)
        {

            int grandeza = resultado4.Length;
            int comparar = 0;
            int troca = 0;

            for (int i = grandeza - 1; i >= 1; i--)

            {

                for (int j = 0; j < i; j++)

                {

                    comparar++;

                    if (resultado4[j] > resultado4[j + 1])

                    {

                        int aux = resultado4[j];

                        resultado4[j] = resultado4[j + 1];

                        resultado4[j + 1] = aux;

                        troca++;

                    }

                }

            }

            return resultado4;

        }

        /* MÉTODO INSERTION SORT */
        void insertion_sort(int[] resultado5, int grandezaVetor)
        {

            int selecionado, j;

            for (int i = 1; i < grandezaVetor; i++)
            {
                selecionado = resultado5[i];
                j = i - 1;

                while ((j >= 0) && (resultado5[j] > selecionado))
                {
                    resultado5[j + 1] = resultado5[j];
                    j--;
                }

                resultado5[j + 1] = selecionado;
            }


        }

        /* MÉTODO SELECTION SORT */
        static int[] SelectionSort(int[] resultado6)

        {

            int min, aux;

            for (int i = 0; i < resultado6.Length - 1; i++)

            {

                min = i;



                for (int j = i + 1; j < resultado6.Length; j++)

                    if (resultado6[j] < resultado6[min])

                        min = j;

                if (min != i)

                {

                    aux = resultado6[min];

                    resultado6[min] = resultado6[i];

                    resultado6[i] = aux;
                }
            }
            return resultado6;
        }

        /* MÉTODO QUICK SORT */
        static int[] QuickSort(int[] resultado7)

        {
            int começo = 0;
            int final = resultado7.Length - 1;
            QuickSort(resultado7, começo, final);
            return resultado7;
        }
        static void QuickSort(int[] resultado8, int começo, int final)

        {
            if (começo < final)
            {
                int x = resultado8[começo];
                int y = começo + 1;
                int z = final;
                while (y <= z)
                {
                    if (resultado8[y] <= x)
                    {
                        y++;
                    }
                    else if (x < resultado8[z])
                    {
                        z--;
                    }
                    else
                    {
                        int troca = resultado8[y];
                        resultado8[y] = resultado8[z];
                        resultado8[z] = troca;
                        y++;
                        z--;
                    }
                }
                resultado8[começo] = resultado8[z];
                resultado8[z] = x;
                QuickSort(resultado8, começo, z - 1);
                QuickSort(resultado8, z + 1, final);
            }
        }

        /* MÉTODO MERGE SORT */
        void Juntar(int[] resultado9, int começo, int meio, int final, int[] resultAux)
        {
            int esquerda = começo;
            int direita = meio;
            for (int i = começo; i < final; ++i)
            {
                if ((esquerda < meio) && ((direita >= final) || (resultado9[esquerda] < resultado9[direita])))
                {
                    resultAux[i] = resultado9[esquerda];
                    ++esquerda;
                }
                else
                {
                    resultAux[i] = resultado9[direita];
                    ++direita;
                }
            }

            for (int i = começo; i < final; ++i)
            {
                resultado9[i] = resultAux[i];
            }
        }

        void MergeSort(int[] resultado10, int começo, int final, int[] resultAux)
        {
            if ((final - começo) < 2) return;

            int meio = ((começo + final) / 2);
            MergeSort(resultado10, começo, meio, resultAux);
            MergeSort(resultado10, meio, final, resultAux);
            Juntar(resultado10, começo, meio, final, resultAux);
        }

        void MergeSort(int[] resultado11, int grandeza)
        {
            int[] resultAux = new int[grandeza];
            MergeSort(resultado11, 0, grandeza, resultAux);
        }


        static void Main(string[] args)
        {
           
            {
                /* Medir o tempo de execução com o Stopwatch */
                Stopwatch sw_desc_insertion = new Stopwatch();
                Stopwatch sw_cres_insertion = new Stopwatch();
                Stopwatch sw_randon_insertion = new Stopwatch();

                Stopwatch sw_desc_selection = new Stopwatch();
                Stopwatch sw_cres_selection = new Stopwatch();
                Stopwatch sw_randon_selection = new Stopwatch();

                Stopwatch sw_desc_bubble = new Stopwatch();
                Stopwatch sw_cres_bubble = new Stopwatch();
                Stopwatch sw_randon_bubble = new Stopwatch();

                Stopwatch sw_desc_quick = new Stopwatch();
                Stopwatch sw_cres_quick = new Stopwatch();
                Stopwatch sw_randon_quick = new Stopwatch();

                Stopwatch sw_desc_merge = new Stopwatch();
                Stopwatch sw_cres_merge = new Stopwatch();
                Stopwatch sw_randon_merge = new Stopwatch();


                /* MÉTODO INSERTION SORT
                  
                   VETOR DECRESCENTE */
                int[] vetor_desc_insertion = new int[10000]; 
                vetor_desc_insertion = vetordecrescente(10000); 

                /*Tempo para iniciar */
                sw_desc_insertion.Start();

                Program ordena_insertion = new Program();
                ordena_insertion.insertion_sort(vetor_desc_insertion, 10000);

                /* Final do tempo */
                sw_desc_insertion.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_insertion = sw_desc_insertion.Elapsed;


                /* VETOR CRESCENTE */
                int[] vetor_cres_insertion = new int[10000]; 
                vetor_cres_insertion = vetorcrescente(10000); 

                Console.WriteLine("\n " + "Vetor ordenardo pelo insertion sort" + "\n");

                /* Tempo para iniciar */
                sw_cres_insertion.Start();

                Program ordena_cres_insertion = new Program(); 
                ordena_cres_insertion.insertion_sort(vetor_cres_insertion, 10000);

                /* Final do tempo */
                sw_cres_insertion.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_cres_insertion = sw_cres_insertion.Elapsed;

                /* VETOR RANDOMICO */
                int[] vetor_randon_insertion = new int[10000]; 
                vetor_randon_insertion = vetorrandomico(10000); 

                /* Tempo para iniciar */
                sw_randon_insertion.Start();

                Program ordena_randon_insertion = new Program(); 
                ordena_randon_insertion.insertion_sort(vetor_randon_insertion, 10000);

                /* Final do tempo */
                sw_randon_insertion.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_randon_insertion = sw_randon_insertion.Elapsed;

                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo total de execução do Insertion Sort Vetor Decrescente : " + tempo_insertion + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Insertion Sort Vetor Crescente : " + tempo_cres_insertion + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Insertion Sort Vetor Randomico : " + tempo_randon_insertion + "\n");
                Console.WriteLine("Tecle Enter para prosseguir");
                Console.ReadKey();
                Console.Clear();

                /* MÉTODO SELECTION SORT 
                 
                   VETOR DECRESCENTE */ 
                int[] vetor_desc_selection = new int[10000]; 
                vetor_desc_selection = vetordecrescente(10000); 

                Console.WriteLine("\n " + "Vetor ordenardo pelo Selection sort" + "\n");

                /* Tempo para iniciar */
                sw_desc_selection.Start();

                SelectionSort(vetor_desc_selection);

                /* Final do tempo */
                sw_desc_selection.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_selection = sw_desc_selection.Elapsed;

                /* VETOR CRESCENTE */
                int[] vetor_cres_selection = new int[10000];
                vetor_cres_selection = vetorcrescente(10000);

                /* Tempo para iniciar */
                sw_cres_selection.Start();

                SelectionSort(vetor_cres_selection);

                /* Final do tempo */
                sw_cres_selection.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_cres_selection = sw_cres_selection.Elapsed;

                /* VETOR RANDOMICO */
                int[] vetor_randon_selection = new int[10000]; 
                vetor_randon_selection = vetorrandomico(10000);

                /* Tempo para iniciar */
                sw_randon_selection.Start();

                SelectionSort(vetor_randon_selection);

                /* Final do tempo */
                sw_randon_selection.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_randon_selection = sw_randon_selection.Elapsed;

                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo total de execução do Selection Sort Vetor Decrescente : " + tempo_selection + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Selection Sort Vetor Crescente : " + tempo_cres_selection + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Selection Sort Vetor Randomico : " + tempo_randon_selection + "\n");
                Console.WriteLine("Tecle Enter para prosseguir");
                Console.ReadKey();
                Console.Clear();

                /* MÉTODO BUBBLE SORT
                 
                   VETOR DECRESCENTE */
                int[] vetor_desc_bubble = new int[10000]; 
                vetor_desc_bubble = vetordecrescente(10000); 

                Console.WriteLine("\n " + "Vetor ordenardo pelo Bubble sort" + "\n");

                /* Tempo para iniciar */
                sw_desc_bubble.Start();

                bubbleSort(vetor_desc_bubble);

                /* Final do tempo */
                sw_desc_bubble.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_bubble = sw_desc_bubble.Elapsed;

                /* VETOR CRESCENTE */
                int[] vetor_cres_bubble = new int[10000]; 
                vetor_cres_bubble = vetorcrescente(10000); 

                /* Tempo para iniciar */
                sw_cres_bubble.Start();

                bubbleSort(vetor_cres_bubble);

                /* Final do tempo */
                sw_cres_bubble.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_cres_bubble = sw_cres_bubble.Elapsed;

                /* VETOR RANDOMICO */
                int[] vetor_randon_bubble = new int[10000]; 
                vetor_randon_bubble = vetorrandomico(10000);

                /* Tempo para iniciar */
                sw_randon_bubble.Start();

                bubbleSort(vetor_randon_bubble);

                /* Final do tempo */
                sw_randon_bubble.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_randon_bubble = sw_randon_bubble.Elapsed;


                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo total de execução do Bubble Sort Vetor Decrescente : " + tempo_bubble + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Bubble Sort Vetor Crescente : " + tempo_cres_bubble + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Bubble Sort Vetor Randomico : " + tempo_randon_bubble + "\n");
                Console.WriteLine("Tecle Enter para prosseguir");
                Console.ReadKey();
                Console.Clear();

                /* MÉTODO QUICK SORT
                 
                   VETOR DECRESCENTE */
                int[] vetor_desc_quick = new int[10000];
                vetor_desc_quick = vetordecrescente(10000); 

                Console.WriteLine("\n " + "Vetor ordenardo pelo Quick sort" + "\n");

                /* Tempo para iniciar */
                sw_desc_quick.Start();

                QuickSort(vetor_desc_quick);

                /* Final do tempo */
                sw_desc_quick.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_quick = sw_desc_quick.Elapsed;

                /* VETOR CRESCENTE */
                int[] vetor_cres_quick = new int[10000]; 
                vetor_cres_quick = vetorcrescente(10000); 

                /* Tempo para iniciar */
                sw_cres_quick.Start();

                QuickSort(vetor_cres_quick);

                /* Final do tempo */
                sw_cres_quick.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_cres_quick = sw_cres_quick.Elapsed;

                /* VETOR RANDOMICO */
                int[] vetor_randon_quick = new int[10000]; 
                vetor_randon_quick = vetorrandomico(10000); 

                /* Tempo para iniciar */
                sw_randon_quick.Start();

                QuickSort(vetor_randon_quick);

                /* Final do tempo */
                sw_randon_quick.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_randon_quick = sw_randon_quick.Elapsed;

                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo total de execução do Quick Sort Vetor Decrescente : " + tempo_quick + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Quick Sort Vetor Crescente : " + tempo_cres_quick + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Quick Sort Vetor Randomico : " + tempo_randon_quick + "\n");
                Console.WriteLine("Tecle Enter para prosseguir");
                Console.ReadKey();
                Console.Clear();

                /* MÉTODO MERGE SORT
                  
                   VETOR DECRESCENTE */
                int[] vetor_desc_merge = new int[10000]; 
                vetor_desc_merge = vetordecrescente(10000);

                Console.WriteLine("\n " + "Vetor ordenardo pelo Merge sort" + "\n");

                /* Tempo para iniciar */
                sw_desc_merge.Start();

                Program ordena_merge = new Program(); 
                ordena_merge.MergeSort(vetor_desc_merge, 10000);

                /* Final do tempo */
                sw_desc_merge.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_merge = sw_desc_merge.Elapsed;

                /* VETOR CRESCENTE */
                int[] vetor_cres_merge = new int[10000]; 
                vetor_cres_merge = vetorcrescente(10000);

                /* Tempo para iniciar */
                sw_cres_merge.Start();

                Program ordena_cres_merge = new Program(); 
                ordena_cres_merge.MergeSort(vetor_cres_merge, 10000);

                /* Final do tempo */
                sw_cres_merge.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_cres_merge = sw_cres_merge.Elapsed;

                /* VETOR RANDOMICO */
                int[] vetor_randon_merge = new int[10000]; 
                vetor_randon_merge = vetorrandomico(10000); 

                /* Tempo para iniciar */
                sw_randon_merge.Start();

                Program ordena_randon_merge = new Program();
                ordena_randon_merge.MergeSort(vetor_randon_merge, 10000);

                /* Final do tempo */
                sw_randon_merge.Stop();

                /* Tempo total do Processo */
                TimeSpan tempo_randon_merge = sw_randon_merge.Elapsed;


                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo total de execução do Merge Sort Vetor Decrescente: " + tempo_merge + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Merge Sort Vetor Crescente: " + tempo_cres_merge + "\n");
                Console.WriteLine("\n" + "Tempo total de execução do Merge Sort Vetor Randomico: " + tempo_randon_merge + "\n");
                Console.WriteLine("Tecle Enter para prosseguir");
                Console.ReadKey();
                Console.Clear();



            }

        }
    }
}