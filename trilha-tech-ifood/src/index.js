console.log("Desafio Classificador de nível de Herói");

let nome = "Mário";
let experiênciaXP = 9000;
let nivel;

if (experiênciaXP <= 1000) {
    nivel = "Ferro";
} else if (experiênciaXP <= 2000) {
    nivel = "Bronze";
} else if (experiênciaXP <= 5000) {
    nivel = "Prata";
} else if (experiênciaXP <= 7000) {
    nivel = "Ouro";
} else if (experiênciaXP <= 8000) {
    nivel = "Platina";
} else if (experiênciaXP <= 9000) {
    nivel = "Ascendente";
} else if (experiênciaXP <= 10000) {
    nivel = "Imortal";
} else {
    nivel = "Radiante";
}

console.log("O herói " + nome + " está no nível " + nivel);

/////////////////////////////////////////////////////////////////////

console.log("Desafio Calculadora de partidas Rankeadas");

let userName = getnomeJogador("Mário");
let resultado = Rankeadas(80, 30);

console.log("O herói " + userName + " está no nível " + resultado);

function getnomeJogador(nome){
    let nomeJogador = nome
    return nomeJogador
}

function Rankeadas(vitorias, derrotas) {
    let saldoVitorias = vitorias - derrotas;
    let nivel;

    if (saldoVitorias <= 10) {
        nivel = "Ferro";
    } else if (saldoVitorias <= 20) {
        nivel = "Bronze";
    } else if (saldoVitorias <= 50) {
        nivel = "Prata";
    } else if (saldoVitorias <= 80) {
        nivel = "Ouro";
    } else if (saldoVitorias <= 90) {
        nivel = "Diamante";
    } else if (saldoVitorias <= 100) {
        nivel = "Lendário";
    } else {
        nivel = "Imortal";
    }

    return nivel;
}

/////////////////////////////////////////////////////////////////////

console.log("Desafio Escrevendo as classes de um jogo");
class Heroi{
  constructor(nome, idade, tipo, ataque){
    this.nome = nome
    this.idade = idade
    this.tipo = tipo
    this.ataque = ataque
  }
  acao(){
      let ataque;
      if(this.tipo === "mago"){
          ataque = "magia"
      }else if(this.tipo === "guerreiro"){
          ataque = "espada"
      }else if (this.tipo === "monge"){
          ataque = "artes marciais"
      }else{
          ataque = "shuriken"
      }
      console.log(`O ${this.tipo} atacou usando ${ataque}`)
  }
}

let heroi1 = new Heroi("Gandalf", 80, "mago");
let heroi2 = new Heroi("Mandubrath", 76, "guerreiro");
let heroi3 = new Heroi("Amadeus", 68, "monge");
let heroi4 = new Heroi("Sneak", 56, "ninja");

heroi1.acao()
heroi2.acao()
heroi3.acao()
heroi4.acao()




