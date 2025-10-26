defmodule BinarySearch do
  @doc """
    Searches for a key in the tuple using the binary search algorithm.
    It returns :not_found if the key is not in the tuple.
    Otherwise returns {:ok, index}.

    ## Examples

      iex> BinarySearch.search({}, 2)
      :not_found

      iex> BinarySearch.search({1, 3, 5}, 2)
      :not_found

      iex> BinarySearch.search({1, 3, 5}, 5)
      {:ok, 2}

  """

  @spec search(tuple, integer) :: {:ok, integer} | :not_found
  def search(numbers, key) do
    search(numbers, key,  0, tuple_size(numbers) - 1)
  end
  
  defp search(numbers, key, min, max) when min <= max do
    mid = div(min + max, 2)
    case elem(numbers, mid) do
      ^key -> {:ok, mid}
      too_big when too_big > key -> search(numbers, key, min, mid - 1)
      _ -> search(numbers, key, mid + 1, max)
    end
    
  end
  defp search(_numbers, _key, min, max), do: :not_found
end
