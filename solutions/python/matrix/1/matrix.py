class Matrix:
    def __init__(self, matrix_string):
        self.string_representation = matrix_string

    def row(self, index):
        string_rows = self.string_representation.split('\n')
        rows = []
        for row in string_rows:
            string_row = row.split()
            int_row = []
            for item in string_row:
                int_row.append(int(item))
            rows.append(int_row)
        return rows[index - 1]

    def column(self, index):
        string_rows = self.string_representation.split('\n')
        rows = []
        for row in string_rows:
            string_row = row.split()
            int_row = []
            for item in string_row:
                int_row.append(int(item))
            rows.append(int_row)
        column = []
        for row in rows:
            column.append(row[index - 1])
        return column
