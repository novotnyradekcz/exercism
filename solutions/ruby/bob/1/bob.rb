=begin
Write your code for the 'Bob' exercise in this file. Make the tests in
`bob_test.rb` pass.

To get started with TDD, see the `README.md` file in your
`ruby/bob` directory.
=end
class Bob
  def self.hey(remark)
    remark = remark.strip

    if remark.empty?
      "Fine. Be that way!"
    elsif remark.upcase == remark && remark.match(/[A-Z]/) && remark.end_with?("?")
      "Calm down, I know what I'm doing!"
    elsif remark.upcase == remark && remark.match(/[A-Z]/)
      "Whoa, chill out!"
    elsif remark.end_with?("?")
      "Sure."
    else
      "Whatever."
    end
  end
end