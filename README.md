# Programação para Dispositivos Móveis (Xamarin)

Disciplina do terceiro semestre (matutino) do curso de Análise e Desenvolvimento de Sistemas na [Faculdade de Tecnologia de Americana](http://www.fatec.edu.br/).

## Referências

*   [Criando aplicativos móveis com xamarin. Forms book](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/creating-mobile-apps-xamarin-forms/)
*   [Xamarin University Self-Guided Learning](https://elearning.xamarin.com/)
*   [Instalação e Configuração do Xamarin no Windows](https://developer.xamarin.com/pt-br/guides/android/getting_started/installation/index.html)
*   [Como Instalar o Xamarin no Visual Studio e criar uma máquina virtual](https://youtu.be/oaJpOwd96_E)
*   [Lista de bibliotecas para Xamarin Forms](https://github.com/XamSome/awesome-xamarin)
*   [Grupo do Facebook](https://www.facebook.com/xamarin.com.br/)

## Ferramentas utilizadas

*   [Visual Studio](https://visualstudio.microsoft.com/pt-br/?rr=https%3A%2F%2Fwww.google.com%2F)
*   [Tiny PNG - Compressão de Imagens](https://tinypng.com/)
*   [Icones](https://material.io/tools/icons/?style=baseline)
*   [Paleta de Cores](https://flatuicolors.com/)
*   [Gradient](https://uigradients.com)

## Projetos desenvolvidos

Projetos desenvolvidos em sala de aula com os alunos

### Projeto 1 - Calculadora de IMC

*   **Layout:** [StackLayout](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/layouts/stack-layout)
*   **Componentes:** [Label](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/text/label), [Entry](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/text/entry), [Button](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/button) e [DisplayAlert](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/app-fundamentals/navigation/pop-ups)
*   **Dicas:** [Conveter tipos](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number) e [Interpolar caracteres](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/tokens/interpolated)
*   **Desafio:** Apresentar a informação da [Tabela do IMC](http://www.calculoimc.com.br/tabela-de-imc/) no DisplayAlert junto com as outras informações do usuário

<p align="center">
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_imc_1.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_imc_2.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_imc_3.png" height="400"/>
</p>

### Projeto 2 - Marcador de Truco 

*   **Layout:** [GridLayout](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/layouts/grid)
*   **Componentes:** Label e Button 
*   **Dicas:** [Parse de string para valores](https://docs.microsoft.com/pt-br/dotnet/api/system.int32.parse?view=netframework-4.7.2), [Interpretando o click no DisplayAlert](http://www.randrade.net/2017/02/08/implementando-alertas-no-xamarin-forms-para-todos-os-sistemas-operacionais/) e [Orientação do dispositivo](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/layouts/device-orientation?tabs=windows)
*  **Desafio:** Apresentar um DisplayAlert para mão de 11; Criar uma forma para desfazer pontuação; Travar a rotação da tela 

<p align="center">
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/marcador_truco_1.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/marcador_truco_2.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/marcador_truco_3.png" height="400"/>
</p>

### Projeto 3 - Calculadora Matemática

*   **Layout:** GridLayout
*   **Componentes:** [TitleView](https://www.andrewhoefling.com/Home/post/xamarin-forms-title-view-a-powerful-navigation-view), Label, Entry e Button
*   **Dicas:** [Manipulação de Strings](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/strings/)
*   **Desafio:** Fazer a calculadora funcionar com números de ponto flutuante (números quebrados) e adcionar uma tecla para inversão de sinal (+/-)

<p align="center">
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_1.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_2.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_3.png" height="400"/>
</p>

### Projeto 4 - Calculadora de Combustível

*   **Layout:** StackLayout e GridLayout
*   **Componentes:** Label, Entry, Button e [NavigationPage](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/app-fundamentals/navigation/hierarchical)
*   **Dicas:** [Aplicar estilos](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/styles/xaml/), [Formato de moeda brasileiro](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings)
*   **Desafio:** Fazer validações para os campos de entrada do usuário e criar um estilo próprio

<p align="center">
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_combustivel_1.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_combustivel_2.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/calculadora_combustivel_3.png" height="400"/>
</p>

### Projeto 5 - Empréstimo de Objetos
*   **Layout:** StackLayout
*   **Componentes:** Label, Entry, Button, NavigationPage, [ListView](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/listview/)
*   **Pacotes:** [sqlite-net-pcl]()
*   **Dicas:** [Método Equals](https://docs.microsoft.com/pt-br/dotnet/api/system.object.equals?view=netframework-4.7.2), [Método GetHashCode](https://docs.microsoft.com/pt-br/dotnet/api/system.object.gethashcode?view=netframework-4.7.2), [DependecyService](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction), [Banco de Dados SQLite](), [Camada de Acesso a Dados (Data Access Layer - DAL)](),
*   **Desafio:** 

<p align="center">
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/emprestimo_objetos_1.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/emprestimo_objetos_2.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/emprestimo_objetos_3.png" height="400"/>
    <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/emprestimo_objetos_4.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/emprestimo_objetos_5.png" height="400"/>
  <img src="https://github.com/kleberandrade/aulas-android-xamarin/blob/master/Screenshots/emprestimo_objetos_6.png" height="400"/>
</p>

## Licença

    Copyright 2019 Kleber de Oliveira Andrade
    
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
    
    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.
    
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.