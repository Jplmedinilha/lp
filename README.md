# lp


MINISTÉRIO DA Educação
Instituto Federal de educação, ciência e tecnologia de São Paulo
Campus Capivari


Nota

Nome do aluno:
Prontuário:
Curso: ADS
Disciplina: LINGUAGEM DE PROGRAMAÇÃO 2
Bimestre: 1º/2022
Data:


Utilizando os conceitos aprendidos no semestre anterior (forms, componentes e principalmente MÉTODOS) desenvolva em C# os seguintes problemas:


    1) Diante dos dados informados pelo usuário e/ou obtido pelo sistema, realize corretamente a saudação conforme os dados informados pelo usuário. 
Por exemplo:

Dados do Exemplo 1: 
Data – 10/07/2022 
Hora – 19h20 
Aluno – Pedro William
Curso – TÉCNICO EM INFORMÁTICA INTEGRADO AO ENSINO MÉDIO
Saudação: BOA NOITE Pedro William, estamos no mês de JULHO. Como aluno(a) do curso TÉCNICO EM INFORMÁTICA INTEGRADO AO ENSINO MÉDIO, seja bem-vindo(a)!
Dados do Exemplo 2: 
Data – 26/06/2022 
Hora – 8h20 
Aluna – MARIA CHIQUINHA 
Curso – LICENCIATURA EM QUÍMICA
Saudação: BOM DIA MARIA CHIQUINHA, estamos no mês de JUNHO. Como aluno(a) do curso LICENCIATURA EM QUÍMICA, seja bem-vindo(a)!


    2) Faça um Programa que leia um número inteiro menor que 1000 e imprima a quantidade de centenas, dezenas e unidades do mesmo.
Observe os termos no plural a colocação do “e”, da vírgula entre outros. Exemplo:
        ◦ 326 = 3 centenas, 2 dezenas e 6 unidades
        ◦ 12 = 1 dezena e 2 unidades Testar com: 326, 300, 100, 320, 310,305, 301, 101, 311, 111, 25, 20, 10, 21, 11, 1, 7 e 16


    3) Desenvolva um programa em C# que seja possível realizar o lançamento do nome do aluno, nota da primeira prova, nota da segunda prova e do trabalho de conclusão da disciplina.
As notas (provas, trabalho e média final) devem ser lançadas com valores de 0,00 à 10,00 e o sistema deverá converter a nota em conceitos conforme os padrões abaixo, sendo MB (muito bom) B (bom) R (Regular) e I (Insatisfatório). Portanto, os valores para estes conceitos devem ser considerados:
    • MB – 8,0 à 10,0
    • B – 6,0 à 7,9
    • R – 4,0 à 5,9
    • I – 0,0 à 3,9

Para o cálculo da média final deverá ser considerado o seguinte peso:
    • P1 – Primeira Prova – peso 3
    • P2 – Segunda Prova – peso 4
    • TCD – Trabalho de Conclusão de Disciplina – peso 3

Portando, a média final é P1 * 3 + P2 * 4 + TCD * 3, devendo esta média final também ser classificada conforme os conceitos aplicados pela escola, sendo considerado REPROVADO apenas os alunos que obtiverem o conceito “I”.
Uma característica fundamental ao sistema é que conforme o conceito obtido, a cor de fundo do formulário é mudada, sendo para estas:
    • MB – verde
    • B – laranja
    • R – amarelo
    • I – vermelho
O sistema deverá tratar as exceções necessárias, bem como a quantidade de casas decimais das notas, além da possibilidade de serem implementadas outras funcionalidades e recursos não solicitados, os quais também serão avaliados.



Boa Atividade!
Prof. Pedro William


dotnet new console-o nome – criar diretorio
dotnet run – run
