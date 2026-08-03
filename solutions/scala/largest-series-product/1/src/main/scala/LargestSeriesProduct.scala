object Series {
  def largestProduct(span: Int, input: String): Option[Int] = {
    if (span <= 0 || span > input.length || input.exists(!_.isDigit)) {
      return None
    }

    val products = for {
      i <- 0 to input.length - span
      series = input.slice(i, i + span)
      product = series.map(_.asDigit).product
    } yield product

    if (products.isEmpty) None else Some(products.max)
  }
}
