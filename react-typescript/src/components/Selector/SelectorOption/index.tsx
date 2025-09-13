
interface SelectorOptionProps extends React.OptionHTMLAttributes<HTMLOptionElement> {
  label: string;
  value: string;
}

export default function SelectorOption({ label, value, ...rest }: SelectorOptionProps) {
  return <option value={value} {...rest}> {label} </option>;
}
