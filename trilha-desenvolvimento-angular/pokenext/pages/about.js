import Image from "next/image"
import styles from '../styles/About.module.css'

export default function About(){
    return (
        <div className={styles.about}>
            <h1>Sobre o projeto</h1>
            <p>Projeto</p>
            <Image src='/images/Pokédex_logo.jpg' width="300" height="120" alt='PokedexLogo'/>
        </div>
    )
}