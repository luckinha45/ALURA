import styles from './Link.module.css'

type LinkProps = {
  href: string,
  children?: React.ReactNode
}

export default function Link(props: LinkProps) {
  return <a className={styles.link} href={props.href}>{props.children}</a>
}
