import styles from './Banner.module.css'

type BannerProps = {
  src: string,
  alt:string
}

export default function Banner(props:BannerProps) {
  return <img src={props.src} alt={props.alt} className={styles.banner} /> 
}

