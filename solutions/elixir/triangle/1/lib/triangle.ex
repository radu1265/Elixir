defmodule Triangle do
  @type kind :: :equilateral | :isosceles | :scalene

  @doc """
  Return the kind of triangle of a triangle with 'a', 'b' and 'c' as lengths.
  """
  @spec kind(number, number, number) :: {:ok, kind} | {:error, String.t()}
  def kind(a, b, c) do 
    if a <= 0 or b <= 0 or c <= 0 do 
      {:error, "all side lengths must be positive"}
    else
      if a + b > c and a + c > b and b + c > a do
        cond do
          a == b and a == c -> {:ok, :equilateral}
          a == b or a == c or b == c -> {:ok, :isosceles}
          true -> {:ok, :scalene}
        end
      else
        {:error, "side lengths violate triangle inequality"}
      end
    end
  end
end
