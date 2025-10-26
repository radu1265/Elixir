defmodule Username do
  defp sanitize_helper(username), do: sanitize_helper(username, [])
  defp sanitize_helper([], converted_username), do: converted_username
  defp sanitize_helper(username, converted_username) do
    [head | tail] = username
    case head do
      ?_ -> sanitize_helper(tail, converted_username ++ [head])
      ?ä -> sanitize_helper(tail, converted_username ++ ~c"ae")
      ?ö -> sanitize_helper(tail, converted_username ++ ~c"oe")
      ?ü -> sanitize_helper(tail, converted_username ++ ~c"ue")
      ?ß -> sanitize_helper(tail, converted_username ++ ~c"ss")
      ch when ch in ?a..?z -> sanitize_helper(tail, converted_username ++ [head])
      _ -> sanitize_helper(tail, converted_username)
    end
  end
  def sanitize(username) do
    sanitize_helper(username)
  end
end
