import styles from '../Header.module.css'

export default function HeaderList({ children }: React.AnchorHTMLAttributes<HTMLUListElement>) {
  return <ul className={styles.menuitem}>{children}</ul>;
}