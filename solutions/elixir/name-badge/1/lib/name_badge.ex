defmodule NameBadge do
  def print(nil, name, department) when department != nil do
    department = String.upcase(department)
    "#{name} - #{department}"
  end
  def print(id, name, nil) do
    if id do
      "[#{id}] - #{name} - OWNER"
    else
      "#{name} - OWNER"
    end
  end
  def print(id, name, department) do
    department = String.upcase(department)
    "[#{id}] - #{name} - #{department}"
  end
end
