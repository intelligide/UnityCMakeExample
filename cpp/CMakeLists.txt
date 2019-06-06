

add_library(hello SHARED hello.cpp)

install(TARGETS hello DESTINATION ${CMAKE_SOURCE_DIR}/Assets/libs)