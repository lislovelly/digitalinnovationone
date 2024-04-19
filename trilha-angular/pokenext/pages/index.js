import styles from '../styles/Home.module.css'
import Image from 'next/image'
import Card from './components/Card'

export async function getStaticProps(){
  const maxPokemons = 251
  const api = 'https://pokeapi.co/api/v2/pokemon/'

  const res = await fetch(`${api}/?limit=${maxPokemons}`)
  const data = await res.json()

  // add pokemon index
  data.results.forEach((item, index) => {
    item.id = index + 1    
  });

  return {
    props: {
      pokemons: data.results,
    }
  }
}

export default function Home({pokemons}) {
  return (
    <>
      <div className={styles.title_container}>
      <Image src='/images/Pokédex_logo.jpg' width="300" height="120" alt='PokedexLogo'/>
      </div>
      <div className={styles.pokemon_container}>
        {pokemons && pokemons.map((pokemon) => (
          <Card key={pokemon.id} pokemon={pokemon}/>
        ))}
      </div>
    </>
  )  
}
