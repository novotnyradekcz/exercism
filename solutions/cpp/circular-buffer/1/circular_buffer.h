#if !defined(CIRCULAR_BUFFER_H)
#define CIRCULAR_BUFFER_H

#include <array>
#include <csignal>
#include <cstddef>
#include <cstdlib>
#include <stdexcept>
#include <memory>
#include <vector>

namespace circular_buffer {
    template<typename T> struct circular_buffer {
        using t_ptr = std::unique_ptr<T>;
        public:
            circular_buffer(size_t size): _size {size}, _r{0}, _w{0}, _buf{new t_ptr[size]} {}
            ~circular_buffer() { delete[] _buf; }
            
            T read();
            void clear();
            void write(const T& v);
            void overwrite(const T& v);
        private:
            void increment(size_t &x) {
                ++x %= _size;
            }
            size_t _size;
            size_t _r;
            size_t _w;
            t_ptr* _buf;
    };
}  // namespace circular_buffer

#endif // CIRCULAR_BUFFER_H