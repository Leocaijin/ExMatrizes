// See https://aka.ms/new-console-template for more information

/*3. Faca um programa que preenche uma matriz com o produto do valor da linha e da coluna
de cada elemento. Em seguida, imprima na tela a matriz*/
/*
int[,]matriz = new int[3,3];

for(int i = 0;i< 3;i++){
    for(int j = 0;j<3;j++){

        matriz[i,j] = i*j;    
    }    
}
Console.WriteLine("Produto da Linha da Matriz pela Coluna: ");
for(int i = 0;i< 3;i++){
    for(int j = 0;j<3;j++){

        Console.Write(matriz[i,j]+"\t");
    }
    Console.WriteLine();
}
--------------------------------------------------------------------------------------------------------------------*/

/*4. Leia uma matriz 4 x 4, imprima a matriz e retorne a localizacao (linha e a coluna) do 
maior valor.*/

int[,]matriz  = new int [4,4];
int maiorValor = int.MinValue;
Random rd = new Random();

for(int i = 0;i< 4;i++){
    for(int j = 0;j< 4;j++){
        matriz[i,j] = (int)(rd.NextDouble()*21);
    }
}
Console.WriteLine("MATRIZ");
for(int i = 0;i<4;i++){
    for(int j = 0;j<4;j++){
        Console.Write(matriz[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int linha = 0;
int coluna = 0;
for(int i = 0;i< 4;i++){
    for(int j=0;j<4;j++){

        if(matriz[i,j]> maiorValor){
            
            maiorValor = matriz[i,j];
           linha = i;
           coluna = j;
        }
    }
}
 Console.WriteLine(" O maior valor é: "+maiorValor);
        Console.WriteLine(" linha: "+linha);
        Console.WriteLine(" coluna: "+coluna);


