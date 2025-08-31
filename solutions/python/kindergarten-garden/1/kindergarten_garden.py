class Garden:
    def __init__(self, diagram, students=["Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"]):
        self.diagram_lines = diagram.split('\n')
        students.sort()
        self.students = students
    def plants(self, student):
        assigned_ps = []
        for line in self.diagram_lines:
            assigned_ps.append(line[2 * self.students.index(student)])
            assigned_ps.append(line[2 * self.students.index(student) + 1])
        assigned_plants = []
        for p in assigned_ps:
            match p:
                case 'G':
                    assigned_plants.append('Grass')
                case 'C':
                    assigned_plants.append('Clover')
                case 'R':
                    assigned_plants.append('Radishes')
                case 'V':
                    assigned_plants.append('Violets')
        return assigned_plants
