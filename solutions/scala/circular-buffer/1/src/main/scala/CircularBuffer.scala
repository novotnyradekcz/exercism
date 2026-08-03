class EmptyBufferException extends Exception("The buffer is empty.")
class FullBufferException extends Exception("The buffer is full.")

class CircularBuffer(var capacity: Int) {
  private val buffer: Array[Option[Int]] = Array.fill(capacity)(None)
  private var readIndex = 0
  private var writeIndex = 0
  private var size = 0

  def write(value: Int): Unit = {
    if (size == capacity) throw new FullBufferException
    buffer(writeIndex) = Some(value)
    writeIndex = (writeIndex + 1) % capacity
    size += 1
  }

  def read(): Int = {
    if (size == 0) throw new EmptyBufferException
    val value = buffer(readIndex).get
    buffer(readIndex) = None
    readIndex = (readIndex + 1) % capacity
    size -= 1
    value
  }

  def overwrite(value: Int): Unit = {
  if (size < capacity) {
    buffer(writeIndex) = Some(value)
    writeIndex = (writeIndex + 1) % capacity
    size += 1
  } else {
    buffer(writeIndex) = Some(value)
    writeIndex = (writeIndex + 1) % capacity
    readIndex = (readIndex + 1) % capacity
  }
}

  def clear(): Unit = {
    for (i <- buffer.indices) buffer(i) = None
    readIndex = 0
    writeIndex = 0
    size = 0
  }
}
