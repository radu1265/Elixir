defmodule TakeANumber do
  def start() do
    spawn(fn -> receive_message(0) end)
  end

  defp receive_message(state) do
    receive do
      {:report_state, sender_pid} -> send(sender_pid, state) 
      receive_message(state)
      
      {:take_a_number, sender_pid} -> send(sender_pid, state + 1)
      receive_message(state + 1)

      :stop -> nil

      _ -> receive_message(state)
    end
  end
end
