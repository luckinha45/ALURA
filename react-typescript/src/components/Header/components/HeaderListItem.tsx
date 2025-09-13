import styles from '../Header.module.css'

export default function HeaderListItem ({ children }: React.LiHTMLAttributes<HTMLLIElement>) {
  return (
    <li className={styles.menuitem}> {children} </li>
  )
}
