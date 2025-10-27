defmodule SquareRoot do
  @doc """
  Calculate the integer square root of a positive integer
  """
  @spec calculate(radicand :: pos_integer) :: pos_integer
  def calculate(radicand) do
    binary_search(radicand, 0, div(radicand, 2) + 1)
    
  end
  
  defp binary_search(target, min, max) when min <= max do
    middle = div((min + max), 2)
    case middle * middle do
      ^target -> middle
      too_big when too_big > target -> binary_search(target, min, middle - 1)
      _ -> binary_search(target, middle + 1, max)
    end
  end
  defp binary_search(_target, _min, _max), do: nil
end
