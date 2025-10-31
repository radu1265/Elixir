defmodule PaintByNumber do
  def palette_bit_size(color_count, acc \\ 0)
  def palette_bit_size(color_count, acc) do
    if 2 ** acc >= color_count do
      acc
    else
      palette_bit_size(color_count, acc + 1)
    end
  end

  def empty_picture() do
    <<>>
  end

  def test_picture() do
    <<0 :: 2, 1 :: 2, 2 :: 2, 3 :: 2>>
  end

  def prepend_pixel(picture, color_count, pixel_color_index) do
    <<pixel_color_index::size(palette_bit_size(color_count)), picture::bitstring>>
  end

  
  def get_first_pixel(<<>>, _color_count), do: nil
  def get_first_pixel(picture, color_count) do
      bit_size = palette_bit_size(color_count)
    <<first_bit::size(bit_size), _rest::bitstring>> = picture
    first_bit
  end
  
  def drop_first_pixel(<<>>, _color_count), do: ""
  def drop_first_pixel(picture, color_count) do
    bit_size = palette_bit_size(color_count)
    <<_first_bit::size(bit_size), rest::bitstring>> = picture
    rest
  end

  def concat_pictures(picture1, picture2) do
    <<picture1::bitstring, picture2::bitstring>>
  end
end
