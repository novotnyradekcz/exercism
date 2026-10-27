class FoodChain
  VERSES = [
    {
      animal: "fly",
      remark: "I don't know why she swallowed the fly. Perhaps she'll die."
    },
    {
      animal: "spider",
      remark: "It wriggled and jiggled and tickled inside her.",
      action: "She swallowed the spider to catch the fly."
    },
    {
      animal: "bird",
      remark: "How absurd to swallow a bird!",
      action: "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her."
    },
    {
      animal: "cat",
      remark: "Imagine that, to swallow a cat!",
      action: "She swallowed the cat to catch the bird."
    },
    {
      animal: "dog",
      remark: "What a hog, to swallow a dog!",
      action: "She swallowed the dog to catch the cat."
    },
    {
      animal: "goat",
      remark: "Just opened her throat and swallowed a goat!",
      action: "She swallowed the goat to catch the dog."
    },
    {
      animal: "cow",
      remark: "I don't know how she swallowed a cow!",
      action: "She swallowed the cow to catch the goat."
    },
    {
      animal: "horse",
      remark: "She's dead, of course!"
    }
  ]

  def self.song
    lyrics = ""

    VERSES.each_with_index do |verse, index|
      lyrics << "I know an old lady who swallowed a #{verse[:animal]}.
"
      lyrics << "#{verse[:remark]}
"

      if index < VERSES.size - 1 && index > 0
        index.downto(1).each do |i|
          lyrics << "#{VERSES[i][:action]}
" if VERSES[i][:action]
        end
        lyrics << "#{VERSES[0][:remark]}
"
      elsif index > 0 && index < VERSES.size - 1
        index.downto(1).each do |i|
          lyrics << "#{VERSES[i][:action]}
" if VERSES[i][:action]
        end
      end

      lyrics << "\n" unless index == VERSES.size - 1
    end

    lyrics
  end
end