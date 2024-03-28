# 1º Checkpoint - Calculadora com Windows Forms

Neste projeto, junto a minha equipe fizemos uma calculadora simples com as funcionalidades (Somar, Subtrair, Dividir e Multiplicar), sendo feita por vontade própria 2 funcionalidades (Limpeza completa (C) ou Limpar um caráctere (←)) para que o usuário final se sinta confortável ao utilizá-lo e poder apagar o que for necessário caso haja algum erro.

## Como funciona as funcionalidades?

Todas as mesmas operações aritméticas, recebem um valor inicial = 1 mais a operação irá zerar a tela da calculadora, demonstrando o simbolo de soma no canto esquerdo como forma de informar ao usuário que já pode inserir o valor final = 2 para com isso apertar no botão igual.

Desta forma, funciona o click nos botões númericos,

```
private void button_1_Click(object sender, EventArgs e)
{
    if (visor_calculo_resultado.Text == "0")
        visor_calculo_resultado.Text = "";

    visor_calculo_resultado.Text += "1";
}
```

Neste caso, o botão das operações funciona da seguinte forma, caso o botão seja acionado irá trazer no botão o **Enum Adicao**, 
fazendo com que o valor seja armazenado logo em seguida e zerando a tela da calculadora para realizar a próxima entrada de dado númerico,
```
private void button_soma_Click(object sender, EventArgs e)
{
    OperacaoSelecionada = Operacao.Adicao;
    Valor = Convert.ToDouble(visor_calculo_resultado.Text);
    visor_calculo_resultado.Text = "";
    lbl_operador.Text = "+";
}
```

Havia sido atribuído no início do código um enum chamado **Operacao** em que foi armazenada na variável **OperacaoSelecionada**, 
na qual a função logo abaixo faz a procura automáticamente da Operação utilizando Switch Case e traz os resultados ao clicar no botão de igual (=),

```
private void button_igual_Click(object sender, EventArgs e)
{
    switch (OperacaoSelecionada)
    {
        case Operacao.Adicao:
            Resultado = Valor + Convert.ToDouble(visor_calculo_resultado.Text);
            break;
        case Operacao.Subtracao:
            Resultado = Valor - Convert.ToDouble(visor_calculo_resultado.Text);
            break;
        case Operacao.Multiplicacao:
            Resultado = Valor * Convert.ToDouble(visor_calculo_resultado.Text);
            break;
        case Operacao.Divisao:
            Resultado = Valor / Convert.ToDouble(visor_calculo_resultado.Text);
            break;
    }
    visor_calculo_resultado.Text = Resultado.ToString(); // Trás o resultado em que o Switch Case reconheceu para o usuário.
    lbl_operador.Text = "="; // Informa ao usuário o sinal igual no canto esquerdo.
}
```

A forma em que o código irá executar será o seguinte,

Inicialmente a calculadora abre com o valor 0,<br>
**Visor: 0**<br>
Ao clicar no número de exemplo 5 irá mostrar no visor substituindo o 0,<br>
**Visor: 5**<br>
Em seguida pressionando uma operação aritmética (+ - x /),<br>
**Visor: +**<br>
Zerando o valor anterior no visor e solicitando o próximo número de exemplo 10 com a operação selecionada no visor da seguinte forma (+   10),<br>
**Visor: + 10**<br>
Ao clicar no botão igual, virá o final da seguinte forma,<br>
**Visor: = 15**
