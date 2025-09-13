import styles from './Button.module.css'

type ButtonProps = {
  variant: 'default' | 'icon',
} & React.ButtonHTMLAttributes<HTMLButtonElement>

export default function Button({children, variant='default', ...rest}: ButtonProps) {
  return <button className={styles[variant]} {...rest}> {children} </button>
}