# These variables are initialized on the command line (using '-v'):
# - name

BEGIN {
    FS = ""
    plant["C"] = "clover"
    plant["G"] = "grass"
    plant["R"] = "radishes"
    plant["V"] = "violets"

    n = split("Alice,Bob,Charlie,David,Eve,Fred,Ginny,Harriet,Ileana,Joseph,Kincaid,Larry", students, ",")
    for(id = 1; id <= n; id++) {
        if(students[id] == name) {
            break
        }
    }

    fst = 0
}
{
    plants = plants (fst++ ? " " : "") plant[$(2*id-1)]
    plants = plants (fst++ ? " " : "") plant[$(2*id)]
}
ENDFILE {
    print(plants)
}
