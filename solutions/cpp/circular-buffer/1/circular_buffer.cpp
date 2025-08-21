#include "circular_buffer.h"

namespace circular_buffer {
    template<typename T> T circular_buffer<T>::read() {
        if (_buf[_r] == nullptr) {
            throw std::domain_error("buffer is empty.");
        }
        auto v = *_buf[_r];
        clear();
        return v;
    }
    template<typename T> void circular_buffer<T>::clear() {
        if (_buf[_r] == nullptr) return;
        _buf[_r].reset();
        increment(_r);
    }
    template<typename T> void circular_buffer<T>::write(const T& v) {
        if (_buf[_w] != nullptr) {
            throw std::domain_error("buffer is full.");
        }
        _buf[_w] = std::make_unique<T>(v);
        increment(_w);
    }
    template<typename T> void circular_buffer<T>::overwrite(const T& v) {
        if (_buf[_w] != nullptr) {
            _buf[_w].reset();
            increment(_r);
        }
        write(v);
    }
}  // namespace circular_buffer

template struct circular_buffer::circular_buffer<int>;
template struct circular_buffer::circular_buffer<std::string>;
